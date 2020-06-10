# :baloon: Online / Offline Support :baloon:

PPC Requirement

## Building a docker image

```sh
docker build -t offline-support .
```

## Containerizing the API

```sh
docker run --rm -it -p 8000:80 --name support offline-support
```

And visit <http://localhost:8000>

:tada: congratz, you have an API running in a docker container!

---
