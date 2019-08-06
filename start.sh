docker start serial-port
docker start contact-ui

STATUS_OUTPUT=/output/info.dat
nohup dotnet /opt/status-monitor/out/status-monitor.dll > /dev/null 2>&1 &