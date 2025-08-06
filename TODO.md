# TODO: Jellyseerr Migration Plan

## Completed
- [x] Bootstrap migration skeleton
- [x] Port media request enums, types, and override hook

## Data Model & Storage
- [x] Merge Jellyseerr request entities into Jellyfin database
- [x] Add tables for media requests, request status, and *arr instances
- [ ] Create EF Core migrations
- [ ] Add indexes for lookups by media, user, and status

## Backend API
- [ ] Port Jellyseerr REST endpoints (request submission, approvals, history)
- [ ] Implement service layer for *arr communication (Radarr, Sonarr, Lidarr, Readarr)
- [ ] Add authentication and permission checks
- [ ] Expose endpoints for admin settings, request queue, and request status
- [ ] Provide WebSocket updates for real-time request changes

## *Arr Integration
- [ ] Build connectors for Radarr/Sonarr/Lidarr/Readarr with test coverage
- [ ] Support multiple *arr servers and profiles
- [ ] Map Jellyfin library paths to *arr root folders
- [ ] Implement quality, language, and tag profile mapping
- [ ] Handle asynchronous job submission and error retries

## Request Workflow
- [ ] Provide search and discover endpoints using existing Jellyfin metadata
- [ ] Implement request creation with approval logic (auto or manual)
- [ ] Integrate media availability checks with existing libraries
- [ ] Display pending/approved/declined requests in UI
- [ ] Allow admins to override or edit requests
- [ ] Track download progress and update status as items are imported

## UI/UX
- [ ] Design screens for Discover, Search, Requests, and Admin settings using Jellyfin theming
- [x] Add request buttons to item detail pages
- [ ] Provide responsive layouts and accessibility
- [ ] Implement notifications or indicators for pending requests
- [ ] Add profile page for personal request history and quotas

## Users & Permissions
- [ ] Map Jellyfin users to request profiles
- [ ] Implement per-user permissions, quotas, and default quality profiles
- [ ] Support guest access where applicable
- [ ] Provide admin roles for approving or denying requests

## Notifications & Automation
- [ ] Port notification providers (Email, Discord, Telegram, Webhook)
- [ ] Add scheduled jobs for syncing request status and library availability
- [ ] Support custom notification templates
- [ ] Provide failure alerts for *arr connectivity

## Documentation & Migration
- [ ] Document configuration steps for *arr integration
- [ ] Provide migration guide from Jellyseerr
- [ ] Add admin UI wizard for *arr setup
- [ ] Record known limitations and future enhancements

## Testing
- [ ] Unit tests for API endpoints and connectors
- [ ] Integration tests for request workflow
- [ ] End-to-end tests for UI flows
- [ ] Load tests for high request volume
- [ ] Ensure coverage for permission checks and notifications

