# Dynamic Reconfiguration

## Context Centric Cluster Computing (C4) in Ad Hoc Network (2016)

Authors [Annadurai and Vijayalakshmi](Context_Centric_Cluster_Computing.pdf) describe the challenges of efficiently managing dynamic cluster configurations. These dynamic systems can add and remove nodes at arbitrary intervals, and the loss of these nodes can influence the availability of desirable routes.

An example scenario would be _Mobile Adhoc Networks_ (MANET), which are used by first responders to large scale disasters. The disaster might have destroyed the existing communication infrastructure. These responders might form a mesh, where each smart phone operates as packet forwarding device. Then ad hoc routes can be formed by bouncing through the mesh to an eventual gateway point. In these scenarios users will walk into/out of range causing the availability paths to those gateways to be volitial.

Another scenario could be services that run on _Amazon Spotfleet_, a very economical compute fabric that does not offer any redundancies. The hosts are permitted to disappear after a two minutes notice. In exchange for accepting these limitations, developers can run their code for pennies on the dollar.

### Security Considerations of C4

One of the challenges within these ad-hoc networks is to ensure the security of peer-to-peer messaging. The authors propose a standard public/private key infrastructure that is based on certificate exchange. What makes there scenario interesting is that the _Cluster Head_ nodes are permitted to join and disjoin similar to the _Cluster Worker_ nodes.

As these head nodes drift out a mechanism is required to rekey all the worker nodes. This mechanism needs to limit the volume of communication for control operations as this reduces the bandwidth for "actually doing stuff."

### How did they address these issues

To address these complexities the authors decomposed the MANET into segments, and then formed a tree structure to connect them. At each junction a stack of previous key states were maintained.

When a new head node joined the environment the junction would rekey itself, and push that key onto the stack. This because the preferred key for communicaiton within the ring. If that head node fell out of scope, then the stack was popped and all nodes reverted to the previous key.

This pattern reduces the number of broadcasts required as there is a fallback entity.
