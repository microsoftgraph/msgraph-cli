# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

### Added

### Changed

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
