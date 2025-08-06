# Plan

## Task: Merge Jellyseerr request entities into Jellyfin database

### Step 1: Review Jellyseerr entities
- Inspect `jellyseerr/server/entity/MediaRequest.ts` and `SeasonRequest.ts` to identify important fields and relationships.

### Step 2: Add enums used by request entities
- File: `jellyfin-server/Jellyfin.Data/Enums/MediaRequestStatus.cs`
- Define `MediaRequestStatus` enum with values `Pending`, `Approved`, `Declined`, `Failed`, `Completed`.
- File: `jellyfin-server/Jellyfin.Data/Enums/MediaRequestType.cs`
- Define `MediaRequestType` enum with values `Movie` and `Tv`.

### Step 3: Create `SeasonRequest` entity
- File: `jellyfin-server/src/Jellyfin.Database/Jellyfin.Database.Implementations/Entities/SeasonRequest.cs`
- Properties: `Id`, `SeasonNumber`, `Status` (`MediaRequestStatus`), `MediaRequestId`, `MediaRequest` navigation, `CreatedAt`, `UpdatedAt`.
- Implement `IHasConcurrencyToken` like other entities and include XML documentation.

### Step 4: Create `MediaRequest` entity
- File: `jellyfin-server/src/Jellyfin.Database/Jellyfin.Database.Implementations/Entities/MediaRequest.cs`
- Properties: `Id`, `RequestedByUserId`, `RequestedBy` navigation (`User`), `TmdbId`, `TvdbId` (nullable), `MediaType` (`MediaRequestType`), `Is4K`, `Status` (`MediaRequestStatus`), `CreatedAt`, `UpdatedAt`, `SeasonRequests` collection.
- Implement `IHasConcurrencyToken` and XML documentation similar to existing entities.

### Step 5: Register entities in `JellyfinDbContext`
- File: `jellyfin-server/src/Jellyfin.Database/Jellyfin.Database.Implementations/JellyfinDbContext.cs`
- Add `DbSet<MediaRequest>` and `DbSet<SeasonRequest>` properties.

### Step 6: Build
- Run `dotnet build jellyfin-server/Jellyfin.sln` to ensure the solution compiles with the new entities.

### Step 7: Commit
- Commit all new and modified files with message `feat(data): add media request entities`.

