# YARP Preformance Testing

## Build

```Shell
docker build -f backend/Dockerfile -t backend:1 .
docker build -f yarp/Dockerfile -t yarp:1 .
```

## Run

```Shell
docker network create yarp
docker run -d --name backend -t backend:1 --network yarp
docker run -d --name yarp -t backend:1 --network yarp -p 81:80
```
