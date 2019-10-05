# Service Discovery in Peer-to-Peer Environments

## Decentralized Resource Discovery Mechanisms for Distributed Computing in Peer-to-Peer Environments (2013)

The authors [Lazaro, D., Marques, J.M., Jorba, J. & Vilajosara, X.](Decentralized_ResourceDiscovery_for_P2P.pdf) "present and classify [resource discovery methods] according to criteria like their topology and the degree of achievement of various common requirements of great importance for the targeted environments, as well as compare their reported performance."

### What are the requirements of the resource discovery systems

- Search Flexibility: The system can match on criteria that is relevant to the resource and caller.
- Scalability: The system can ensure QoS is delivered in a consistent manner.
- Churn and Fault Tolerance: Resources can go offline for a number of reasons and the ecosystem needs to handle these scenarios.
- Completeness: Does the search return a reasonable list of potential matches
- Accuracy: Are the search results acceptable to the search criteria, or does the caller need to do additional validation
- Security: Are the resources protected from malicious and accidential behaviors
- Performant: The search criteria is executed in a reasonable time frame

### What are their design characteristics

- Overlay Topology: A virtual topology with supernodes that encompass one or more physical nodes/links
  - Structured: Typically a distributed hash table (DHT) that uses a variant of Key Based Routing
  - Ring: Nodes are numerically indexed and they hold a collection of keys
  - Multidimensional Space: Overlay networks like Content Addressable Networks (CAN) use an identifier to point to _D-dimensional values_
  - Tree: Overlays that are hierarchial, care is required to avoid the root becoming a bottleneck
  - Unstructured: A predefined structure is not present and they are ad-hoc constructed
- Emergent Underlying Topologies: The physical environment can influence the design of the overlay (e.g. these servers are on the same rack)
- Degree of centralization:
  - Local Centralization: The behavior when one node is responsible for a subset of peers
- Information Spread Method
  - Pull/Push
