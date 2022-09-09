import os

# HOOFD-'KLANTDIRECTORY'
os.mkdir('Projectnaam00000000000')

# 1 diep, 1 folder: src- THE SOURCEFOLDER!
os.makedirs('Projectnaam00000000000/src')
# 1 diep, 1 folder: test- Unit tests, integration tests
os.makedirs('Projectnaam00000000000/test')
# 1 diep, 1 folder: test- for local configurations
os.makedirs('Projectnaam00000000000/.config')
# 1 diep, 1 folder: .build- All scripts related to the buildprocess. ie: powershell, docker, compose ...
os.makedirs('Projectnaam00000000000/.build')
# 1 diep, 1 folder: dep- This is where all Dependencies go 
os.makedirs('Projectnaam00000000000/dep')
# 1 diep, 1 folder: doc- The documentationfolder
os.makedirs('Projectnaam00000000000/doc')
# 1 diep, 1 folder: res- For all static resources
os.makedirs('Projectnaam00000000000/res')
# 1 diep, 1 folder: samples- helloworld and co-code that supports documentation
os.makedirs('Projectnaam00000000000/samples')
# 1 diep, 1 folder: tools- Convenience-directory
os.makedirs('Projectnaam00000000000/tools')

# 1 diep, 1 folder: .gitignore- List of blobs for git to ignore. Affects commands like git add and git clean.
# Gecommenteerde lijn, verwijder comment voor her-activatie: os.makedirs('Projectnaam00000000000/.gitignore')
# 1 diep, 1 folder: .gitignore- List of blobs for git to ignore. Affects commands like git add and git clean.
os.makedirs('Projectnaam00000000000/.mailmap')
# 1 diep, 1 folder: .gitignore- Let’s you define submodules.(subdirectories of your git repository which are checkouts of other git repositories).
os.makedirs('Projectnaam00000000000/.gitmodules')
