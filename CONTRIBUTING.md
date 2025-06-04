# Contributing to Codex

Thank you for taking the time to contribute! This project contains a .NET backend and an Angular frontend. The following guidelines help keep the workflow consistent for everyone.

## Getting Started

1. Fork the repository and create your feature branch from `main`.
2. Install dependencies:
   - Backend: use [.NET 8](https://dotnet.microsoft.com/) and run `dotnet restore server/Codex.sln`.
   - Frontend: navigate to `client` and run `npm ci`.
3. Make your changes and commit regularly with clear messages.

## Running Tests

Before opening a pull request, ensure that both backend and frontend tests pass:

```bash
# Backend tests
dotnet test server/Codex.sln

# Frontend tests
cd client
npm test -- --watch=false --browsers=ChromeHeadless
```

## Pull Requests

- Ensure your PR describes the change and references any related issues.
- Keep PRs focused and small when possible.
- After tests succeed, open a pull request targeting the `main` branch.

We appreciate your help in improving Codex!
