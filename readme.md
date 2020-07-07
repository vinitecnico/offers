## .Net Core 3.1

Run application use command:

```
dotnet run
```
Swagger:

```
https://localhost:5001/swagger/index.html
```

## Test coverage

Run test coverage
```
dotnet test /p:CollectCoverage=true

dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
```

## Docker

Build image docker:

```
docker build -f ci/Dockerfile.build -t netcoreoffer .
```

Run build image:

```
Docker run -d -p 8080:80  netcoreoffer
```

Swagger run docker:
```
http://localhost:8080/swagger/index.html
```
