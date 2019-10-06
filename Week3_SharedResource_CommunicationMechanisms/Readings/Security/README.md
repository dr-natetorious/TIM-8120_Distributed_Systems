# Security

## A Hybrid Secure Scheme for Wireless Sensor Networks against Timing Attacks Using Continuous-Time Markov Chain and Queueing Model (2016)

The authors [Tianhui Meng; Xiaofan Li; Sha Zhang; and Yubin Zhao](Hybrid_SecureScheme_for_WirelessSensorNetworks.pdf) discuss security challenges in wireless sensor networks, that are caused by the limited power and introduction of timing attacks that traditional cryptography cannot mitigate.

> Since these networks are usually deployed in remote areas and left unattended, they should be defended by security mechanisms against attacks, such as physical tampering, node capture, eavesdropping, denial of service, etc. Unfortunately, traditional security mechanisms with high overhead are not feasible for the resource-constrained sensor nodes [6]. An important issue of WSNs is how to preserve sensitive measurements taken from everyday life where data privacy is an essential aspect. In many scenarios, the confidentiality of propagated data can be considered critical.
> [...]
> Energy is an essential resource of WSNs, so the implementations of cryptographic algorithms in such systems often perform computations in non-constant time due to performance optimization. The timing attack involves algorithms that have non-constant execution time, and this can potentially leak secret information. As represented in [12], the operating system running on the sensor nodes is event-driven and extremely optimized in terms of memory consumption, which suggests that the timing side-channel is practical in WSNs.

The rekeying process with an optimal rate is introduced into the WSNs, and random paddings are interposed in the processing time to mitigate the information leakage of the timing side-channel. Our contributions are now summarized as follows:

- In order to proceed to a quantitative treatment of the performance-security tradeoff of WSNs, we propose a hybrid continuous-time Markov chain (CTMC) and queueing model for the system under the specific threat of timing attacks.
- We have shown the measures’ formulation, including both security and performance attributes, and the optimal tradeoff between the two.
- Experimental evaluations demonstrate the effectiveness of the random padding countermeasure against timing attacks and the tradeoff improvement one can obtain from the proposed scheme.

### Proposed Scenario

There is one or more command nodes that cannot be captured with many sensor nodes that can be physically modified. These sensor nodes are modified to send messages with a random length pad attached to the end. This randomization makes it difficult to measure the time taken and access the contained secret.

Publisher keys are stored in flash memory as part of the provisioning process and can be rekeyed using a generic Diffie-Hallman (GDH) process.

> Simply, a timing attack is on in which the attacker repeatedly send guesses about a secret valueto the target machine, which rejects them as incorrect. However, if his or her first byte of the guess is correct, it takes a very slightly longer time to return the error. With enough measurements and proper filtering, the attacker can distinguish this difference and guess the secret correctly. The key idea of conducting a timing attack is to find the processing time differences. In order to simplify the implementation, we mimic a timing attack by recording and analyzing the gateway node response time to compare two values bit by bit.
