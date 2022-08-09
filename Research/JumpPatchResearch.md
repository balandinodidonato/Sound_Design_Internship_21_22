Game Audio Performance Testing Optimisation <p>
  Jump Patch Testing
  <pre>
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------|
  |   Revision    |             CPU Consumption            |     Output Type     |            Controllable Parameters           | Activation Methodology  |
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------|
  | Patch Version | Peak CPU Usage % | Average CPU Usage % | Mono | Stereo | 5.1 |      |             |           |             | One Shot |  Continuous  |
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------|
  |   REV3        |     0.18         |        0.07         |  Y   |        |     |      |             |           |             |    Y     |              |
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------| 
  |   REV4        |     0.09         |        0.05         |  Y   |        |     |      |             |           |             |          |      Y       |
  |---------------|------------------|---------------------|------|--------|-----|------|-------------|-----------|-------------|----------|--------------|
  
  Disclaimer:
	These values were gathered while all other Source Plugins were disabled. The Bit Crusher plugin however was still active.
  Numbers aquired from Wwise Profiler in real time, numbers provided guidance only. These are not mathmatically calculated (in the case of the Average)
  Performance and percentage consumption will vary depending on the hardware specifications of the host system.
</pre>
