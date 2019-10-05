# Communication Mechanisms

Sharing of information in a distributed system is important. Access to shared data is regularly required by processes and users in the system for meaningful cooperation. These entities in the system expect that there will be guarantees about how data is shared and managed. If a system is designed to share data, it should satisfy a number of requirements before allowing data to be shared. Clients should have access to data in its most recent form and the degree of availability must be high (the first condition is in direct conflict with this). If these are met, a client will be able to reach a copy of the file at all times and even remotely stored items will be treated as local.

In networks and distributed systems, communication refers to the transmission of packets and messages. This week, you will study what elements need to be considered to connect each node on the system to make interprocess and intraprocess communications possible. Protocols and procedures make sure processes are managed through the right communication channels. As studied in Section 1, there are three major types of networks today: LAN, WAN, and Cloud. The main categories or type of nodes in a distributed network are communications, servers, clients, and transmission media. All these are components of a client/server architecture.

- Server: Handles network operating systems, enterprise applications, file and printer sharing, storage, communications, and mails servers, among other services. Some tools used to manage shared resources are semaphores (NOS); remote procedure calls (RPC); message-oriented middleware (MOM) for application, database, and file servers; and transmission protocols like TCP/IP for transmission media.

- Client: Nodes or computers that connect either locally or remotely and share resources, request services, files, and data for transaction processing.
Transmission Media: Peripherals, nodes, wires, and connectors needed to establish the connection and manage resources.
In networks and distributed systems, a protocol is a special set of rules, standards, and policies used to establish a connection, communications, and distribution channels between nodes in a network. Widely used protocols are packet-switching, TCP/IP, Wi-Fi, Bluetooth, routing protocols, among many others. These protocols are implemented across all layers of the distributed system.

To establish and manage communications in distributed systems, a model or framework must be correctly configured, understood, documented, and managed. Management suites with resource management capabilities assist in managing complex installations. A model formally presented during the 1980s is the open systems interconnection, or OSI, model. It is a representation of network layers and how messages and packets are sent over a network. The OSI model is comprised of seven layers, one dependent on the other, which is why they are called a protocol stack:

- Physical Layer: Cables, connectors, and electromagnetic conversion of data to be transmitted over physical wires or aerial connections.
- Data Link Layer: Protocols to send and receive packets.
- Network Layer: Protocols for routing messages and handling congestion.
- Transport Layer: Protocols for setting the layer transition to application packets, as well as media streaming of data.
- Session Layer: Protocols to set the stage for packet conversion to applications.
- Presentation Layer: Protocols for application interaction and communication for data processing.
- Application Layer: Protocols for transaction processing, file transfers, email, web access, among others.

Other important protocols to study in this chapter are:

- TCP/IP (Transmission Control Protocol—Internet Protocol)—the standard used these days for most Internet connections.
- Remote Procedure Call (RPC)—a small script or code developed in a low-level language that locally calls a procedure to request service connection to another instance in the distributed system landscape (internal or remote), and then establishes the handshake or connection prior to sending packets of data in its raw form. One of the goals of an RPC is to act as if the call is always local. The basic steps to execute an RPC are:
  - The initiating procedure calls the client or data manager from the receiver side.
  - The initiating procedure or instance sends a message to the receiver operating system to establish a secure connection before starting packet transmission.
  - The remote or receiving node sends a response to the initiating node.
  - The initiating node packs and transmits the packets to the receiving node.
  - The receiving node unpacks or decodes the packets to build the message or file and get it ready to upload either to the database server, email server, or application.
  - The receiving node sends an acknowledgment to the sending node to confirm successful receipt of the packets.
- Middleware Protocols—applications used or embedded within the OSI model.
  - Domain Name System (DNS)—distributed service to look at and validate network address or domains.
  - Persistent Communication—message submitted and retransmitted until it reaches its destination.
  - Transient Communication—message transmitted only when both sender and receiver processes are running.
