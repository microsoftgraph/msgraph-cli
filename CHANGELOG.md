# Changelog

All notable changes to this project will be documented in this file.

## [1.6.0](https://github.com/microsoftgraph/msgraph-cli/compare/v1.5.0...v1.6.0) (2024-04-08)


### Features

* **generation:** update request builders and models ([#456](https://github.com/microsoftgraph/msgraph-cli/issues/456)) ([6c65d64](https://github.com/microsoftgraph/msgraph-cli/commit/6c65d64dc0585c9407b0b735e6c3a77b7a360038))

## [1.5.0](https://github.com/microsoftgraph/msgraph-cli/compare/v1.4.0...v1.5.0) (2024-03-19)


### Features

* **generation:** update request builders and models ([#450](https://github.com/microsoftgraph/msgraph-cli/issues/450)) ([ba4c72b](https://github.com/microsoftgraph/msgraph-cli/commit/ba4c72bd7ec7431f7a58a746b6ae99da3b3bb962))

## [1.4.0](https://github.com/microsoftgraph/msgraph-cli/compare/v1.3.1...v1.4.0) (2024-02-14)


### Features

* **generation:** update request builders and models ([#431](https://github.com/microsoftgraph/msgraph-cli/issues/431)) ([a6727d6](https://github.com/microsoftgraph/msgraph-cli/commit/a6727d64c8d2c573591bef4f007409bf1b3f5e85))

## [1.3.1](https://github.com/microsoftgraph/msgraph-cli/compare/v1.3.0...v1.3.1) (2024-02-14)


### Bug Fixes

* fix issue with saving auth data when cloud environment is changed ([#432](https://github.com/microsoftgraph/msgraph-cli/issues/432)) ([cba4fad](https://github.com/microsoftgraph/msgraph-cli/commit/cba4fade745ae9ed2261f24e9690cb9255156358))

## [1.3.0](https://github.com/microsoftgraph/msgraph-cli/compare/v1.2.0...v1.3.0) (2024-02-06)


### Features

* add national clouds support ([#423](https://github.com/microsoftgraph/msgraph-cli/issues/423)) ([f29cc5c](https://github.com/microsoftgraph/msgraph-cli/commit/f29cc5cc52ebc9e2e67b7605c22722e29db4ba93))
* **generation:** update request builders and models ([#428](https://github.com/microsoftgraph/msgraph-cli/issues/428)) ([ae339fb](https://github.com/microsoftgraph/msgraph-cli/commit/ae339fbabcd89173042e602b5b6357f3016fd157))

## [1.2.0] - 2024-01-22

### Added

### Changed

- Updated .NET version to 8.0. [#417]

## [1.1.1] - 2023-12-11

### Added

### Changed

- Fix index out of range issue when no args are provided. [#404]


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
