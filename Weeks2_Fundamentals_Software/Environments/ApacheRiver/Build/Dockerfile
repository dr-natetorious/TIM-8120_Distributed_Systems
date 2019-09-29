# Note: 
#   Apache River sources are from Oct 5th 2016
#   Use build tools that are roughly from that period
FROM debian:jessie
LABEL Maintainer="Nate Bachmeier"
LABEL Course="TIM-8120 Distributed Systems"
LABEL School="NorthCentral University"
LABEL CreatedDate="2019.09.29"

# Get the dependencies for building the system
RUN apt-get -y update && apt-get -y install curl zip ant default-jdk maven nano

# Download and extract the main sources...
WORKDIR /src
ENV RIVER_HOME /src/apache-river-3.0.0

RUN curl -o apache-river-3.0.0-src.tar.gz http://apache-mirror.8birdsvideo.com/river/river-3.0.0/apache-river-3.0.0-src.tar.gz
RUN tar -xvf apache-river-3.0.0-src.tar.gz
WORKDIR /src/apache-river-3.0.0
RUN ant all.build

# Download and extract the examples...
RUN curl -o river-examples-1.0-source-release.zip http://apache-mirror.8birdsvideo.com/river/river-examples-1.0/river-examples-1.0-source-release.zip
RUN unzip river-examples-1.0-source-release.zip
WORKDIR /src/river-examples-1.0
RUN mvn install
RUN mvn site
