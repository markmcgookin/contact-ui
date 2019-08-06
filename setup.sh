docker pull dockerregistry.local:5000/markmcgookin/serial-port-monitor:latest
docker pull dockerregistry.local:5000/markmcgookin/contact-ui:latest

docker run --name serial-port -d  -e SERIAL_PORT="/dev/ttyACM0" --device=/dev/ttyACM0 --restart unless-stopped dockerregistry.local:5000/markmcgookin/serial-port-monitor
docker run --name contact-ui --net=host --env="DISPLAY" --volume="$HOME/.Xauthority:/root/.Xauthority:rw" --restart unless-stopped dockerregistry.local:5000/markmcgookin/contact-ui