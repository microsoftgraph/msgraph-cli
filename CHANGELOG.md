# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

### Changed

## [1.1.0] - 2023-11-29

### Added

### Changed

- Fix calendar-view list. [#389]

## [1.0.0] - 2023-11-20

### Added

- Added `me` command. Use `mgc me get` to fetch the currently logged in user.

### Changed

## [1.0.0-rc.2] - 2023-10-24

### Added

### Changed

- Use stderr for log output. [#359]
- Fix token refresh on incremental consent. [#352]
- Convert `--json-no-indent` flag to `raw_json` output option. Use it via `--output raw_json`. [#362]
- Improve error messages on authentication failure. [#369]
- Remove `REQUIRED` text from output option description. [#362]
- Always allow account selection on login.

## [1.0.0-rc.1] - 2023-09-26

### Added

- Added managed identity login. Use `mgc login --strategy ManagedIdentity` to use it.

### Changed

- Changed output encoding to `utf-8` for better compatibility with other tools like `jq` [#341]
- Fix line breaks on output [#341]
- Fix headers parsing breaking on '=' in header value. [#343]


## [1.0.0-rc.0] - 2023-09-20

### Added

### Changed


## [1.0.0-preview.2] - 2023-09-06

### Added

- Added headers support via the `--headers` option.

### Changed

- Fixed issue with command conflicts in the parser.


## [1.0.0-preview.1] - 2023-06-16

### Added

- Added overloaded OData functions as commands. Examples of newly added command
paths:
  - `mgc drives items workbook worksheets charts image-with-width`
  - `mgc drives items workbook worksheets charts image-with-width-with-height`

### Changed

- `--file` has now been split into `--input-file` and `--output-file` to cater
for endpoints that accept a stream and return a stream.
- Fix error when accessing `mgc users direct-reports graph-org-contact`. There
are now 2 similar commands under `mgc users direct-reports graph-org-contact`.
  - `mgc users direct-reports graph-org-contact`
  - `mgc users direct-reports graph-org-contact-by-id`

## [0.4.0-preview.1] - 2023-05-05

### Added

### Changed
- Set console encoding to utf-8
- Remove `item` place-holder from commands with url path parameters
- Update samples.

## [0.3.0-preview.1] - 2023-03-16

### Added
- Add Environment login. Client secret login and certificate file login are now possible with this new strategy.

### Changed
- Update login command help text.
- Fix a bug where the CLI didn't send the Content-Type header when sending requests with bodies.

## [0.2.0-preview.1] - 2023-02-27

### Added

### Changed
- Change MacOS & Linux packages to use tar archives
- Fix Azure Identity logs showing when not needed

## [0.1.0-preview.8] - 2023-02-10

### Added
- Added documentation content for non-terminal sub-commands
- MacOS binaries are now signed and notarized.

### Changed
- Logout now clears tokens from the cache.
- Header command options can now be called multiple times. The header values will now be additive.

## [0.1.0-preview.7] - 2022-09-28

### Added
- Added certificate login (`mgc login --strategy ClientCertificate`)
- Added `--debug` option

### Changed
- Implement `none` output formatter as no-op output


## [0.1.0-preview.6] - 2022-08-18

### Added
- Added interactive browser login (`mgc login --strategy InteractiveBrowser`)

### Changed
- Fix issue with corrupted config files on changing user accounts

## [0.1.0-preview.5] - 2022-06-10
### Added
- Add item sub-command for indexer paths (paths with id). `GET /users/{user-id}` changes from `mgc users get --user-id` to `mgc users item get --user-id`
- Add command samples.
- Add automatic page iteration via the `--all` command option.

### Changed
- Login command scopes are now optional.
- Fix issue with nullable boolean options.
- Fix issue with incorrect OData parameter names.
- Fix issue with docker container missing capabilities when running as a non-root user.
- API requests now send an `Accept` header to the server. The value of the header is determined by the schema.

## [0.1.0-preview.4] - 2022-04-19

### Added
- Add default app id & tenant id
- Add documented headers as command options

### Changed
- Make app settings configuration file optional

## [0.1.0-preview.3] - 2022-03-17

### Added

- Added support for JMESPath queries #35
- Added clientId and tenantId parameters to the login command #40

### Changed

- Fixed bug caused by URL path parameters not being set in the request information object #38
- Fixed stream output being passed to output formatter when no file path is provided #38
- Format JSON output by default. The formatting can be disabled per command through the CLI argument `--json-no-indent` #55
- Use async OutputFormatter & OutputFilter APIs #55
- Fix failing requests when adding options like `--select`, `--expand`, `--top` etc
