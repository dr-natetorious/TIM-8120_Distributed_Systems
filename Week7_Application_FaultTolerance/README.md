# Section 4: Week 7: Data Structures and Fault Tolerance

In order to effectively manage and control resource allocation and process execution, it is important to first understand how they are organized—plus anticipate potential sources of failure to categorize them and establish correcting or mitigating strategies or processes. To understand and design fault tolerance approaches in distributed systems, first the concepts of availability, reliability, and safety must be carefully considered before choosing the right data structure algorithm to implement.

1. Availability—can be defined as the property or state indicating that nodes, systems, and processes can be used immediately.
2. Reliability—can be thought of like the consistency or state that a node or system is performing well and functioning normally, and processes can be executed with minimal risk of failure.
3. Safety—can be thought of as the guarantee that, should a process or node fail, the integrity of the systems or processes will not be seriously damaged, exposed, or compromised.

Among the types of failure a distributed system can experience are:

## Types of failures in a distributed system

|Type of Failure|Description|
|Crash Failure|System was working fine, then halts (fail-stop, fail-safe, fail-silent)|
|Omission Failure|Fails to receive incoming messages. Fails to respond to or send messages|
|Timing Failure|The time intervals between inbound and outbound messages is inconsistent or delayed|
|Response Failure|The correctness and integrity of message content or responses are not correct or follows a different control flow|

One of the most basic data structures in computer science is the tree structure. A tree structure is a hierarchical model of the data where each node belongs to a parent node until you reach the root node of the data. Your hard drive, for example, has a root of either C: or \ (depending on operating system) and all files and folders can be accessed by traveling from the root node and following a path of connections to the desired node—in this case the subsequent folders and files, organized in a hierarchical structure similar to branches and leafs in a tree.

Be sure to review this week's resources carefully. You are expected to apply the information from these resources when you prepare your assignments.
