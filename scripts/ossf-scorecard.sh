githubPAT=$(op read op://Coderox/GitHubPAT/credential)
docker run -e GITHUB_AUTH_TOKEN=$githubPAT --platform linux/arm64 gcr.io/openssf/scorecard:stable --repo=$1