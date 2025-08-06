import { useQuery } from '@tanstack/react-query';
import { MediaType } from 'constants/media';
import type { MediaRequest } from 'types/mediaRequest';
import type { ServiceCommonServer, ServiceCommonServerWithDetails } from 'types/service';

interface OverrideStatus {
    server?: string;
    profile?: string;
    rootFolder?: string;
    languageProfile?: string;
}

const fetchServers = async (
    type: MediaType
): Promise<ServiceCommonServer[]> => {
    const res = await fetch(`/api/v1/service/${type === MediaType.MOVIE ? 'radarr' : 'sonarr'}`);
    if (!res.ok) {
        throw new Error('Failed to fetch services');
    }
    return res.json();
};

const fetchServerDetails = async (
    type: MediaType,
    id: number
): Promise<ServiceCommonServerWithDetails> => {
    const res = await fetch(
        `/api/v1/service/${type === MediaType.MOVIE ? 'radarr' : 'sonarr'}/${id}`
    );
    if (!res.ok) {
        throw new Error('Failed to fetch service details');
    }
    return res.json();
};

const useRequestOverride = (request: MediaRequest): OverrideStatus => {
    const { data: allServers } = useQuery({
        queryKey: ['service', request.type],
        queryFn: () => fetchServers(request.type)
    });

    const { data } = useQuery({
        queryKey: ['service', request.type, request.serverId],
        queryFn: () => fetchServerDetails(request.type, request.serverId as number),
        enabled: !!request.serverId
    });

    if (!data || !allServers) {
        return {};
    }

    const defaultServer = allServers.find(
        (server) => server.is4k === request.is4k && server.isDefault
    );
    const activeServer = allServers.find((server) => server.id === request.serverId);

    return {
        server:
            activeServer && request.serverId !== defaultServer?.id ?
                activeServer.name :
                undefined,
        profile:
            defaultServer?.activeProfileId !== request.profileId ?
                data.profiles.find((profile) => profile.id === request.profileId)?.name :
                undefined,
        rootFolder:
            defaultServer?.activeDirectory !== request.rootFolder ?
                request.rootFolder :
                undefined,
        languageProfile:
            request.type === MediaType.TV
            && defaultServer?.activeLanguageProfileId !== request.languageProfileId ?
                data.languageProfiles?.find(
                    (profile) => profile.id === request.languageProfileId
                )?.name :
                undefined
    };
};

export default useRequestOverride;
