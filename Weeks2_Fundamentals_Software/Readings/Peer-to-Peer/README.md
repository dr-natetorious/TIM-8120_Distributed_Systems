# Peer-to-Peer Architectures

## Lateral Exchange Markets: How Social Platforms Operate in a Networked Economy (2018)

The authors [Perren, R; Kozinets, R](LateralExchangeMarkets.pdf) explore "Lateral exchange markets (LEMs) are sites of technologically intermediated exchange between actors occupying equivalent network positions." These topologies are naturally occurring in scenarios such as: _peer-to-peer sharing_; _gig economy_ (e.g. AirBnB, Uber, ...); and _pay per use systems_ (e.g. Zipcar and Redbox).

They intentionally avoid using the term `peer` as it suggests that the third-party is an amature, in reality 20-40% of the "share economy" is operated by professionals (property management firm -> AirBnB) or former-professionials in a related trade (eg. taxi -> uber driver). For this reason `LEMs` are the preferred term for describing these scenarios.

> Therefore, in contradistinction to prior conceptualizations, we aim to build a general understanding about these markets that conceptualizes them as (1) a broad marketplace phenomenon with internal differences, (2) a manifestation of technology platforms linking actors, (3) including the possibility for exchange of ownership and not merely access, (4) excluding sharing and gifts, and (5) including both amateur (“peer”) and professional actors.
> We define a lateral exchange market (LEM) as a market that is formed through an intermediating technology platform that facilitates exchange activities among a network of equivalently positioned economic actors.

![lem_related_literature.png](lem_related_literature.png)

### What are the types of LEMS

- Distinct value propositions of LEM types
- Forums connect actors
- Enablers equip actors
- Matchmakers pair actors
- Hubs centralize and standardize service flows

![lateral_market_types.png](lateral_market_types.png)

### What is the point

> After examining a large set of LEMs and analyzing how they function, we develop four LEM types. The types have two underlying trust-related dimensions: [1] the extent of consociality between actors and [2] the extent of intermediation of the platform.

This conclusion can be applied to distributed software systems by understanding where a system fits on these dimensions. If it drifts too far in any direction then compensations are required to ensure a safe and reliable platform. The authors use the extreme of Craiglist with _high consociality and low platform intermediation_ -- that offsets the high risks with user training.

Understanding these mesh networks is important as not all ecosystems can be fully trusted. Consider a Mobile Ad Hoc Network (MANET) as discussed with [Context Centric Cluster Computing (C4) in Ad Hoc Network (2016)](../../Week1_Fundamentals_Hardware/Readings/Autoscale/README.md) where ad hoc users use thier mobile devices as packet forwarding devices. Without secure design considerations, any of these forwarding devices could manipulate the transmission to include malware or bogus results.

![lem_magic_quad.png](lem_magic_quad.png)
