# Shared Memory Management and Naming

There are many models of distributed computing to manage shared memory and naming schemes. It is critical to implement a viable shared memory management model to maximize resource utilization in support of the applications to be executed across the network. These memory models need to occur between the processor and memory component internals of the systems. Three basic models for shared memory used are loosely coupled systems, closely coupled systems, and tightly coupled systems.

- Loosely Coupled Systems—In this model, nodes can asynchronously communicate and exchange messages. Each system is independent and autonomous while connected to others in the network to share resources.
- Closely Coupled Systems—In this model, nodes run only one operating system with a single domain name scheme and security domain, but still share physical and logical resources like processors, memory, and files.
- Tightly Coupled Systems or Parallel Systems—In this model, nodes share memory in a synchronous manner, has a single address space and single bus to connect and manage processors and memory.
The network operating system applies processes for network memory management like a single contiguous location, partitioned allocation, paged and segmented allocation for network activity management and data manipulation and processing.

In distributed systems, the implementation and management of a solid naming scheme system are essential for optimal network performance, scalability, integrity, and security. A name in a distributed system is a string of bits or characters that is used to refer to an entity (Van Steen, Tanenbaum, 2017). Each node in the system must have a name associated with it to avoid network collision from the node or entity side. Names must be assigned from physical nodes (computers, printers, switches, routers, firewalls) to logical nodes (files, programs, web services, network connections). Node names can be independent or flat but will still identify the node location in the system and helps maps the location and function of each within the distributed system. This is an important function for scalability of nodes in the system.

When establishing naming schemes, it is important to follow a model or naming standard to differentiate each node and its function without needing to know its exact location—but while still being able to map it in the network. These naming standards must be meaningful and representative of the nodes or entities. Address resolution protocols are used to identify the origin of the nodes initiating a message before granting access through the network. This is the concept of broadcasting messages in a network.

This week, you will explore the benefits of systems memory sharing models and naming schemes.

Be sure to review this week’s resources carefully. You are expected to apply the information from these resources when you prepare your assignments.

Reference:

Ghosh, S. (2015). Distributed Systems—An Algorithmic Approach. 2nd.Ed. Boca Raton. CRC Press.
Tanenbaum, A. S. & van Steen, M. (2017). Distributed Systems. (3rd ed.). Maarten van Steen Publisher.
