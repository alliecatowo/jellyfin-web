import type { RouteObject } from 'react-router-dom';
import { DiscoverPage } from 'discover';

export const DISCOVER_APP_ROUTES: RouteObject[] = [
    {
        path: '/discover',
        Component: DiscoverPage
    }
];
