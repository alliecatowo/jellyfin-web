# Plan

This document captures the end‑to‑end vision for merging Jellyseerr's request
and discovery features into Jellyfin. It is **immutable** – future changes to
scope or tasks live in `TODO.md`.

## 1. Data Model & Storage
1. Port core request entities from Jellyseerr into `Jellyfin.Database`.
2. Introduce tables for media requests, request status history and season
   requests.
3. Store information about external *Arr instances (Radarr, Sonarr, Lidarr,
   Readarr).
4. Provide EF Core migrations for new tables with indexes on media, user and
   status lookups.

## 2. Backend API
1. Expose REST endpoints for submitting, approving and tracking requests.
2. Implement service layer communicating with *Arr APIs using configured
   instances.
3. Enforce authentication, permissions and per‑user request quotas.
4. Provide admin endpoints for managing *Arr servers, quality profiles and
   request queues.
5. Emit WebSocket events for real‑time request updates.

## 3. *Arr Integration
1. Build connectors for Radarr, Sonarr, Lidarr and Readarr with retry logic and
   test coverage.
2. Map Jellyfin libraries to *Arr root folders, quality and language profiles.
3. Support multiple *Arr servers and profiles per media type.
4. Synchronize request status with *Arr download and import progress.

## 4. Request Workflow
1. Leverage existing Jellyfin metadata to provide search and discovery APIs.
2. Allow users to create requests with auto‑approval or manual approval flows.
3. Track availability by periodically syncing existing libraries.
4. Display pending, approved and declined requests in user and admin views.
5. Permit admins to edit or override requests and monitor download progress.

## 5. UI / UX
1. Add a Discover tab showcasing trending and upcoming media using TMDB/TVDB.
2. Include request buttons on item detail pages with status indicators.
3. Create screens for request submission, history, approvals and admin settings.
4. Ensure responsive layouts, accessibility and Jellyfin theming.
5. Notify users of request status changes within the UI.

## 6. Users & Permissions
1. Map Jellyfin users to request profiles with optional guest access.
2. Implement per‑user permissions, quotas and default quality profiles.
3. Support admin roles for approving or denying requests.

## 7. Notifications & Automation
1. Port notification providers (Email, Discord, Telegram, Webhook).
2. Add scheduled jobs for syncing request status and library availability.
3. Support customizable notification templates and failure alerts.

## 8. Documentation & Migration
1. Document configuration steps for *Arr integration and migrations.
2. Provide a migration guide for existing Jellyseerr installations.
3. Implement an admin setup wizard for *Arr configuration.
4. Maintain a list of known limitations and future enhancements.

## 9. Testing
1. Unit tests for API endpoints, connectors and permission logic.
2. Integration tests for request workflows and *Arr communication.
3. End‑to‑end tests for major UI flows.
4. Load tests to validate high request volume scenarios.
