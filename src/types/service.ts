export interface QualityProfile {
    id: number;
    name: string;
}

export interface RootFolder {
    id: number;
    path: string;
}

export interface Tag {
    id: number;
    label: string;
}

export interface LanguageProfile {
    id: number;
    name: string;
}

export interface ServiceCommonServer {
    id: number;
    name: string;
    is4k: boolean;
    isDefault: boolean;
    activeProfileId: number;
    activeDirectory: string;
    activeLanguageProfileId?: number;
    activeAnimeProfileId?: number;
    activeAnimeDirectory?: string;
    activeAnimeLanguageProfileId?: number;
    activeTags: number[];
    activeAnimeTags?: number[];
}

export interface ServiceCommonServerWithDetails {
    server: ServiceCommonServer;
    profiles: QualityProfile[];
    rootFolders: Partial<RootFolder>[];
    languageProfiles?: LanguageProfile[];
    tags: Tag[];
}
