---
Title: Use Mongo DB for document database and host on Azure PaaS.
Category: Architecture Decision Record
Published: 05/06/2023
Author: James Brewster
---
In the context of Document Databases for application containers
Facing the need to host semi-structured data, close to the service
We decided to use Mongo DB interfaces on Azure Cosmos DB service
And against using a cosmos DB interface or a native mongo DB container
To simplify hosting the DB and to keep the database cloud agnostic
Accepting that we will have to ensure that we don;t use vendor specific features on Cosmos and that there is some cross service latency fromt he container to Cosmos
Because, at this time, there is no real need to be fully multi-cloud and the native Azure Cosmos Interfaces are being deprecated at some point.

Discussed with James Brewster, Peter Wilson, Jamie Milligan and Simon King.