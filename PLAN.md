# Jellyseer-in-Jellyfin Migration Plan

This document captures the high-level vision and scope for integrating Jellyseerr's discovery and request features directly into Jellyfin.

## Vision
- Provide a native discovery and request workflow in Jellyfin.
- Achieve feature parity with standalone Jellyseerr while leveraging Jellyfin's existing infrastructure.

## Scope
- **Backend**: merge Jellyseerr database schema, APIs, authentication, jobs, and notifications into Jellyfin's server stack.
- **Frontend**: add a Discover tab to the web client offering trending, popular, recommendations, watchlists and request management.
- **Compatibility**: optional Overseerr API shim and cross-platform notifications.

This file is immutable; revisions must be recorded via additional documentation (e.g., ADRs).
