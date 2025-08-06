export enum MediaRequestStatus {
    PENDING = 1,
    APPROVED,
    DECLINED,
    FAILED,
    COMPLETED
}

export enum MediaRequestType {
    MOVIE = 'movie',
    TV = 'tv'
}

export enum MediaStatus {
    UNKNOWN = 1,
    PENDING,
    PROCESSING,
    PARTIALLY_AVAILABLE,
    AVAILABLE,
    BLACKLISTED,
    DELETED
}

export interface SeasonRequest {
    id: number;
    seasonNumber: number;
    status: MediaRequestStatus;
}

export interface MediaRequest {
    id: number;
    mediaId: number;
    type: MediaRequestType;
    status: MediaRequestStatus;
    requestedByUserId: number;
    is4k: boolean;
    createdAt: string;
    seasons?: SeasonRequest[];
}
