import { MediaType } from 'constants/media';

export interface MediaRequest {
    id: number;
    type: MediaType;
    is4k: boolean;
    serverId?: number;
    profileId?: number;
    rootFolder?: string;
    languageProfileId?: number;
}
