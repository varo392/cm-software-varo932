<<<<<<< HEAD
#!/bin/sh

if [ ! -d "venv" ]; then
    python -m venv venv
fi
venv/bin/pip install texttest
venv/bin/texttest -d . -con "$@"
=======
#!/bin/sh

if [ ! -d "venv" ]; then
    python -m venv venv
fi
venv/bin/pip install texttest
venv/bin/texttest -d . -con "$@"
>>>>>>> 6a4b9ba17e222d481b4320690b2cc76948ef446c
