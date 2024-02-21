## Instructions to verify solution.

### Solution summary
- "LongestIncreasingSequence.Lib" project has the actual solution of the problem.
- "LongestIncreasingSequence.App" project that accepts user input and show solution to the console output.
- "LongestIncreasingSequence.UnitTests" project has all required unit tests for this problem.

### Prerequisite
- This solution is built in .Net 7. System must require .Net 7 sdk
- Docker is required to check the solution in docker.

### Review solution

1. Run below commands to make solution running in the Docker. Go to the solution folder
	- docker build . -t lis
	- docker run -i lis:latest
2. Just run "LongestIncreasingSequence.App"


