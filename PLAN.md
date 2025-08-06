# Jellyseer-in-Jellyfin Migration Plan

This document defines the long-term vision for folding Jellyseerr's discovery and request system into Jellyfin.

## Vision
- Provide a native discovery and media request workflow in Jellyfin.
- Maintain feature parity with standalone Jellyseerr and add polish through Jellyfin's ecosystem.

## Scope
### User Interface
- Integrate a `Discover` tab in the web SPA with trending, popular, recommendations, watchlists and request management.
### Backend
- Port Jellyseerr's Prisma schema into Jellyfin's Entity Framework model.
- Expose request and discovery APIs within Jellyfin's existing API namespace.
- Rework notifications, job queues and authentication to use Jellyfin services.

## Phases
1. Schema merge
2. API port
3. Front-end integration
4. Auth & ACL
5. Notifications & job queue
6. Cleanup and removal of legacy Jellyseerr runtime

This file is immutable; revisions must be captured via supplementary documents such as ADRs.
