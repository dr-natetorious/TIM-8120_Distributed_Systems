# Modeling Performance and Reliability

## Modeling Message Queueing Services with Reliability Guarantee in Cloud Computing Environment Using Colored Petri Nets (2015)

The authors [Jing Li Yidong Cui and Yan Ma](Queuing_with_Reliability_Guarantee_in_CloudComputing.pdf) walk over the process of using _Colored Petri Nets_ to model distributed FIFO queue services, like Amazon Simple Queue Service (SQS).

### What modeling tool did they use

They recommend using [CPN Tools v4.0](http://cpntools.org/) for creating and simulating these environments.

## Performance modeling and analysis of message-oriented event-driven systems (2013)

The authors [Kai Sachs; Samuel Kounev; and Alejandro Buchmann](Performance_Modeling_and_Analysis_of_MessageOriented_EventDriven_Systems.pdf) state "with [Message-Oriented Middleware (MOM)] increasing adoption in mission-critical areas, the performance and scalability of such systems are becoming a major concern. To ensure adequate qualityof-service (QoS), it is essential that applications are subjected to a rigorous performance and scalability analysis as part of their software engineering life cycle."

> However, the decoupling of communicating parties in event-driven applications makes it difficult to predict their behavior under load and ensure that enough resources are available to meet QoS requirements.
> [...]
> Most existing techniques suffer from simplifying assumptions limiting their practical applicability and do not consider important system aspects that occur in realistic applications such as different communication patterns, multiple message types and message persistence.

### What benchmark does this article use

> The [SPECjms2007](http://www.spec.org/osg/jms2007) benchmark workload comprises a set of supply chain interactions between a supermarket company, its stores, its distribution centers and its suppliers. The interactions represent a complex transaction mix exercising both point-to-point and publish/subscribe messaging including one-to-one, one-tomany and many-to-many communication [2]. The benchmark covers the major message types used in practice including messages of different sizes and different delivery modes, i.e., persistent versus non-persistent, transactional versus non-transactional. The generated interaction mix can be configured to represent different types of customer workloads.

### How do the authors model the problem

They use Queuing Petri Nets (QPNs) and can be understood by following Appendix A in the paper. This section will walk through a complete introduction to the philosophy and process.

### What QPN tools did they use

> [They] employed the QPME tool (Queueing Petri net Modeling Environment) [12,13] to build and analyze the QPN models of the benchmark interactions. QPME is an opensource tool providing a QPN editor for constructing QPN models and an optimized simulation engine SimQPN [6] for model analysis. SimQPN has already been successfully used in multiple modeling studies of significant size and complexity and has been shown to scale well to large realistic systems.
