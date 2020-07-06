dotnet run

https://localhost:5001/swagger/index.html


##docker

docker build -f ci/Dockerfile.build -t netcoreoffer .

docker run -d -p 8080:80  netcoreoffer

http://localhost:8080/swagger/index.html
