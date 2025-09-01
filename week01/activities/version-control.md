# W01 Assignment: Explain Version Control

Overview

Articulate the principle of version control.

Question: What is version control and why is it important?

Version control is a system that allow a person or group of people to keep a history of the changes mades on files,
there are different version control system available, the most popular now days is Git. When working with version
control it uses a workflow system to manage the changes made by a person into file/files. Git uses three-stage model system
that are called working directory, staging area, local repository, and remote repository. Changes to files must be
added and later saved (commited), the commits are saved on the local repository, and later can be saved on remote
repository. This is a powerfull solution to allow teams to work in small to large projects using branches, because the changes
are saved and can be shared with other via the remote repository.

A commit is a statment of the changes that are added and saved, like a snapshot of the moment that it was stored on the local
repository, this keeps track of the files that were changed and the changes made between commits. Since the commits are
responsable to keep the state of the files it will determine in case there are conflicts that needs to be addressed between
state/changes made to a individual file.

Version control allow to work with branches, that basically creates a separated working directory that's isolated to other states
previously saved, it will keep the timeline changes from a given point (commit). With that in mind teams can work on different features
or problems without affecting the changes that another team mate is working on. This concept later allows to merge changes within other
branche(s), making it an excellent solution to work on a code base project with multiple people.

A couple of examples of version control commands are given below, this commans are use with git:

1. Add changes to a staging area
git add main.py -> added main.py file to staging area
git add . => added all untracked files to staging area

2. Creating a state (commit) of the current saved files on staging area with a message
git commit -m "initial commit"

3. Pushing (sending) states (commits) to remote repository
git push origin

4. Pulling (receiving) states (commits) from remote repository
git pull origin

5. Merging (join) branches
git checkout A -> change to branch A
git merge B -> join changes from branch B

By using a version control solution like git it allow a person to keep track of the necessary changes it's working on and later share this
changes with others by sending or receiving the changes of a remote repository. These changes can be pushed (sended) to the remote repository and
pulled (received) from the remote repository. Since the state is managed by the version control it will keep track of the changes that can cause
conflicts between states, this is great because in case 2 people makes changes to the same file git will warn the changes that must be resolved
before pull or push changes to a remote repository and this principal is applied to merge between branches.
