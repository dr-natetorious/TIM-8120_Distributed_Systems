# Business Process Execution Language

Authors [Venkatesan and Sridhar](Arch_NextGen_EnterpriseScale.pdf) discuss extensions for BPEL, a workflow technology for orchestrating web service calls.

Located within this same folder are PowerPoint decks detailing both the `Business Value` and `Technical Overview` of the BPEL standard. 

## Programming Model

Their implemenetation relies on [Apache Orestration Director Engine (ODE)](https://ode.apache.org/) to execute their Xml based job definitions. A _Programming in the large / Programming in the small pattern_ is used to implement the job.

*Programming in the Large* refers to the high level language that uses Xml tags to describe the invocations to various _actions_.
*Programming in the Small* refers to the Java code behind that implement individual _action_.

The pattern allows a decoupling of design for business level domain experts from the code monkeys.

## ACtive Internet Application Framework

BPEL natively supports performing _Remote Procedure Calls_ by marshalling data structures to web endpoints. The operation binding is discovered through Web Service Description Language (WSDL).
