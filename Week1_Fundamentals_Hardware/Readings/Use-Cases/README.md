# Use Cases of Distributed Hardware Systems

## High Performance Cluster Computing as a Tool for 4G Wireless System Development (2014)

Authors [Thiele, Wirth, Oblrich, Schierl, Haustein, and Frascolla](HPC_and_4G_Wireless.pdf) discuss the challenges with building a Digital Signal Processor (DSP) with software. These scenarios frequently arise within video encoding as realtime images need to be transmitted to the audience.

### Transitioning to Virtual Network Functions

Histroically, these systems have been built with hardware, which has made them expensive to operate and limits innovation. Instead the systems need to transition to Virtual Network Functions (see [TIM-7010-Computer_Networks_and_Mobile_Computing](https://github.com/dr-natetorious/TIM-7010-Computer_Networks_and_Mobile_Computing) Section 1).

As VNF components, they can be dynamically provisioned and upgraded in a highly efficient manner. Operational costs are also reduced as shared hardware can be used instead of dedicated machines.

### Introducing High Performance Clusters

However there are challenges with software performing at the same speeds as hardware. One approach has been to deploy FPGA controllers as they can fill the hybrid space of hardware speeds with software agility.

Another strategy is to improve the encoding algorithms so they can be performed in parallel across multiple rendering nodes. The authors took this approach and configured a _High Performance Computing Service_ (HPCS) cluster. This was able to accept arbitrary tasks and schedule those processes on free nodes within the multi-server environment.

### Running Code at the Data

High resolution video can quickly grow to enormous scale. Instead of moving this data around the data center, the paper proposes moving the code to execute "directly" on the storage nodes. This pattern is well documented in other big data solutions, such as Hadoop.
