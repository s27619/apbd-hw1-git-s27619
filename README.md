Added description for calculator methods.

This merge was not a fast-forward merge because it involved a merge between two branches with their own commit history.
The history of the main branch showed a commit for the README change, while the feature-max branch showed a commit for the implementation of the CalculateMax method.

Added information about min calculation.

Merge maintains the branch structure but creates a merge commit.
Rebase is used to rewrite the commit history by replaying commits on top of another branch.
This results in a linear commit history without any merge commits.

1. When does Git perform a fast-forward and when is a merge commit created?
A conflict was intentionally introduced by making changes to the same line of code in the feature conflict branch as well as in the main branch. When trying to merge these branches, 
Git put a flag indicating that there was a conflict in the code in the Program.cs file. The conflict was marked, showing the changes made in both versions of the code. To resolve the conflict, 
changes were made by analyzing both changes and creating a new version of the code. The changes were then merged into one version of the code, resolving the conflict. The file was then staged, resolving the merge.
2. What is the practical difference between merge and rebase?
The main difference is how they integrate changes into the project history. Merge combines two branches by creating a merge commit, preserves the full branching history, the commit graph shows where branches were created and merged.
Rebase moves or replays commits from one branch on top of another branch, creates a linear history without additional merge commits and the history looks cleaner but the original branch structure is not preserved.
3. How was the conflict resolved in the repository?
A conflict was intentionally created by modifying the same line of code in both the feature-conflict branch and the main branch. When attempting to merge the branches, Git marked the conflicting section in Program.cs. The conflict markers showed both versions of the code.
The conflict was resolved manually by reviewing both changes and combining them into a single final version of the message. After removing the conflict markers and confirming the code still compiled, the resolved file was staged and the merge commit was completed.