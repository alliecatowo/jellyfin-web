# Plan

This document describes the complete migration path to integrate Jellyseerr-style discovery and request capabilities into Jellyfin. It is an immutable high-level blueprint; individual tasks are tracked in TODO.md.

## 1. Data Model & Storage
- Introduce enums for request states and media types.
- Define entities: MediaRequest, SeasonRequest, ArrInstance, and request status history if needed.
- Map entities with EF Core configuration, including indexes for media, user, and status lookups.
- Create migrations to add tables for requests, season requests, arr instances, and supporting indexes.

## 2. Backend API
- Port Jellyseerr REST endpoints for submitting requests, approvals, history, and settings.
- Implement service layer that communicates with Radarr, Sonarr, Lidarr, and Readarr.
- Add authentication and permission checks.
- Expose admin endpoints for request queue management and configuration.
- Provide WebSocket push updates for realtime request changes.

## 3. *Arr Integration
- Build reusable connectors for each *Arr application with unit tests.
- Support multiple servers and quality/root folder profile mapping.
- Handle asynchronous job submission, retries, and error reporting.

## 4. Request Workflow
- Provide search and discovery endpoints leveraging Jellyfin metadata.
- Implement request creation with auto-approval logic and manual review capabilities.
- Integrate availability checks to prevent duplicate requests.
- Track download progress and update request status as items are imported.
- Allow admins to edit or override requests.

## 5. UI/UX
- Add Discover and Search screens using Jellyfin theming.
- Show request buttons on item detail pages and indicators for request states.
- Provide profile pages for request history and quotas.
- Ensure responsive layouts and accessibility.
- Surface notifications for request lifecycle events.

## 6. Users & Permissions
- Map Jellyfin users to request profiles.
- Implement per-user permissions, quotas, and default quality profiles.
- Support guest access when enabled.
- Provide admin roles for managing requests and settings.

## 7. Notifications & Automation
- Port notification providers (Email, Discord, Telegram, Webhook, etc.).
- Add scheduled jobs to sync request status and library availability.
- Support customizable notification templates and failure alerts.

## 8. Documentation & Migration
- Document *Arr integration and configuration steps.
- Provide migration guides from Jellyseerr.
- Add admin UI wizard for *Arr setup.
- Record known limitations and future enhancements.

## 9. Testing & QA
- Unit tests for API endpoints, connectors, and permissions.
- Integration tests covering request workflow.
- End-to-end UI tests for major flows.
- Load tests for high request volume.
