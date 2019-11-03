# Data Integrity Readings

## Remote data integrity checking with server-side repair (2017)

The authors [Bo Chen and Reza Curtmola](RemoteDataIntegrity_checking_with_server_side_repair.pdf) describe a protocol for _remote integrity checks across replicated data_. What makes their approach novel is that it assumes the replica servers are malicious, and will cheat if they can.

### Replica on the fly Attack (ROTF)

A malicious service could charge the client for 5 replicas and then only store it 4 times.  The client would never notice, if the services can reconstruct the 5th instance on the fly. A mechanism needs to exist to detect this behavior and ensure services paid for occur.

Their proposal is to make the cost of creating a replica from scratch prohibitively expensive. While this is possible against a static aversary, an elastic and dynamically scalable adversary can overcome computationally expensive limits.

One strategy to protect against these elastic attackers is to chain sequences of checksums into a cryptographic algorithm. If the remote service already has all of the desired blocks, then it can quickly feed the values into the check. However, if they are not present then the recursive nature drastically increases the computation required.

### Setup, Challenge, Repair Protocol

The authors propose a strategy for confirming that each of the replicas are consistent and complete. The `Setup` begins with the coordinator randomly selecting `N blocks` in `File F`. It then sends a `Challenge` for each service to return the `MAC tag` (e.g. SHA256) that describes the each involved block. If the _spot checked blocks_ contain different hashes, then a `Repair` operation needs to resync the state.
