# Messaging System, "dumb pipes" pattern

As services scale in a microsoervices architecture, they need to communicate. A communication network is important, to make sure each service can easily talk to the others, but as they scale, its important to make sure they can grow and continue to communicate.

This pattern builds off the principle of 'Smart end-points, dumb pipes'. If the pipes are clever, they need maintenance, everyone has to wait on the team which is responsible for the pipe, and that reduces time to market.

If the pipe is dumb, anyone can send a message easily, anyone can consume a message easily. they may need to adjust the format, but thats something they can do within their own team.

## Illustration

## Rationale

Summarizing all of the above, the benefits of smart end points and dumb pipes are:

* Lower cost of messaging infrastructure - pushes the cost of goods sold closer to the producer and consumer. Allows messaging infrastructure to scale by number of messages instead of computational complexity of messages. License cost is reduced as fewer compute nodes are needed for message transit.
* Organization Scalability – teams aren’t reliant on transforms created by a centralized team.
* Low Latency – because computation is limited, messages are delivered more quickly and predictably to end consumers.
* Capacity and scalability of messaging infrastructure – increased significantly as compute is not part of the scale of the platform.
* Availability of messaging infrastructure – because compute is removed, so is a type of failure. As such, availability increases.

## Assumptions

* Messages will need to be in a defined format, which anyone can reference and understand on their own. An API with a contract is a good way to do this.
* Teams will need to adhere to contracts. These can be changed (issues, etc.), but this should be done properly.

## References

[Architecture Principles: Messaging Systems – Smart End Points, Dumb Pipes | AKF Partners](https://akfpartners.com/growth-blog/architecture-principle-messaging-systems-smart-end-points-dumb-pipes)

