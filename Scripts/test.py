import sys
from pathlib import Path
import subprocess

print("Checking if VSIX exists at ", sys.argv[1])

my_file = Path(sys.argv[1])
if my_file.is_file():
    print("VSIX correctly generated.")
else:
    print("VSIX was not correctly generated.")
    sys.exit(1)