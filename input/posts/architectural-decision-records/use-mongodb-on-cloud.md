---
Title: Use Mongo DB for document database and host on Azure PaaS.
Category: Architecture Decision Record
Published: 05/06/2023
Author: James Brewster
---
  In the context of Document Databases for application containers,
  
  Facing the need to host semi-structured data close to the service.

  We decided to use Mongo DB interfaces on Azure Cosmos DB service
  
  And against using a Cosmos DB interface or a native Mongo DB container.

  To simplify hosting the DB and to keep the database cloud agnostic
  
  Accepting that there is some cross-service latency between the container and the Cosmos Service on Azure.

  Because Microsoft is deprecating the native Azure Cosmos Interface.

Discussed with James Brewster, Peter Wilson, Jamie Milligan and Simon King.
