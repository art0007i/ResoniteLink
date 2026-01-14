---
title: Security
---

The ResoniteLink repository implements some security measures to ensure that the shipped library is as safe as possible for end-users.

## Default protections

### Branch protection

The default branch, `master` has a default protection level following those rules:
- Merge request needed for code to be added
- Force pushes are disabled
- Deletions are heavily restricted

### Scanners

Multiple scanners are triggered on each push, be it for merge requests, or the main branch:
- Secret scanning
- CodeQL analysis (warns about known patterns)

Scanners will output their results in the "security" tab of the repository (only visible to engineering team members).

### Dependabot

Runs periodically and will warn about outdated dependencies, and sometimes even open Merge Requests automatically to patch those.

### Push secret protection

If a secret is detected during a `push` event, the push will be rejected by GitHub.

## Security reports

Please report any security-related issues to [our support website](https://support.resonite.com), selecting "security ticket".
