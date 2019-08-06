#Remove the old folder if it exists
rm -r -f /opt/status-monitor

#Create a clean directory
mkdir -p /opt/status-monitor

#Download the latest version
wget http://jenkins.local:8081/builds/status-monitor/status-monitor-latest.tar.gz

#Extract to the install directory
tar zxf status-monitor-latest.tar.gz -C /opt/status-monitor

#Cleanup the download
rm -f status-monitor-latest.tar.gz

#Setup docker stuff
docker pull dockerregistry.local:5000/markmcgookin/serial-port-monitor:latest
docker pull dockerregistry.local:5000/markmcgookin/contact-ui:latest

docker stop contact-ui
docker stop serial-port

docker rm contact-ui
docker rm serial-port

docker create --name serial-port -e SERIAL_PORT="/dev/ttyACM0" --device=/dev/ttyACM0 dockerregistry.local:5000/markmcgookin/serial-port-monitor
docker create --name contact-ui --net=host --env="DISPLAY" --volume="$HOME/.Xauthority:/root/.Xauthority:rw"  dockerregistry.local:5000/markmcgookin/contact-ui