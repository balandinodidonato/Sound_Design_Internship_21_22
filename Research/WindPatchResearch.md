Game Audio Performance Testing Optimisation <p>
  Wind Patch Testing
  <pre>
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------|
  |   Revision    |             CPU Consumption            |     Output Type     |            Controllable Parameters           | Activation Methodology  |
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------|
  | Patch Version | Peak CPU Usage % | Average CPU Usage % | Mono | Stereo | 5.1 | Gain | wind Force  | Direction | Temperature | One Shot |  Continuous  |
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------|
  |   REV4        |   2.273          |   0.08              | Dual |        |     |  Y   |             |           |             |          |      Y       |
  |               |                  |                     | Mono |        |     |      |             |           |             |          |              |
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------| 
  |   REV11       |   0.255          |   0.14              |      |   Y    |     |  Y   |      Y      |           |      Y      |          |      Y       |
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------|
  
  Disclaimer:
  Numbers aquired from Wwise Profiler in real time, numbers provided guidance only.
  Performance and percentage consumption will vary depending on the hardware specifications of the host system.
