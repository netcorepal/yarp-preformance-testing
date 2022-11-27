# YARP Preformance Testing

## Build

```Shell
docker build -f backend/Dockerfile -t backend:1 .
docker build -f yarp/Dockerfile -t yarp:1 .
```

## Run

```Shell
docker network create yarp
docker run -d --name backend  --network yarp -t backend:1
docker run -d --name yarp  -p 81:80 --network yarp  -t yarp:1


 helm upgrade backend .\helm-charts-backend -n default
```

Open: <http://localhost:81>

Output：

```txt
Hello World!
```
