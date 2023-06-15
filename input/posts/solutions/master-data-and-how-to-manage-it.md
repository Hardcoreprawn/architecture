---
Title: Master Data and How to Manage it
Lead: Master Data is critical to an organisation's function. Master Data Management is the process of organising and collating it.
Description: Master data management is the organisation of people, processes and technologies to create and maintain a reliable data environment for master data.
Tags:
  - Architecture
  - Data
  - Solutions
Categories:
  - Solutions
Draft: true
Published: 2023-06-12T12:40:06.193Z
Author: James Brewster
---

## Introduction

Master Data management is the organisation of people, processes and technologies to create and maintain a reliable data environment for master data.

>[The Tale of Two Customers (James B & Bing AI, 2023)](xref:a-tale-of-two-customers) shows how well-understood, linked Master Data can help improve customer experience and business success. It talks about two experiences of customer service, one positive and one negative, through the eyes of Alice (who has a good experience) and Bob (who has a bad one).
>
>I think we've all been Alice or Bob at some point, and it's likely that when we felt like Alice, we used the company again. And when we felt like Bob, we avoided them and repeatedly told our friends and family about the poor experience.

## Master Data

Master Data is a confusing term.

This article refers to 'the critical information required to run the organisation' as 'Master Data'. Each department may have its own. Acquisitions will have their own. Partners will have their own.

How do we ensure our Enterprise has an up-to-date, single view of the customer?

**By Managing our Master Data**.

Master Data management (MDM) is the organisation of people, processes and technologies to create and maintain data in a way which is:

* Authoritative
* Reliable
* Sustainable
* Accurate
* Secure

Great if you are lucky enough to have a single system which everyone uses to track orders, shipments, payments and work items. Your data is already probably mastered and accurate. A design like this is a business's 'gold standard' of information management.

But it's rarely found in any but the smallest or largest organisations. Small organisations cope with limited systems. The larger ones invest heavily in creating designs that match their processes and allow this interaction.

For everyone else, we need to understand and link data to simplify our work and limit the expense of supporting our customers while offering them a great experience they want to return to.

Easy access to a single record system eases and supports the business. Each area may use a different database system, but as long as the resulting view is consistent, this will not harm the organisation.

Ideally, we want to try and limit the number of systems customer-facing colleagues are using. They should be able to work in one place to ease training and stress.

MDM involves creating or documenting a master record for each entity in the company's central processes to synchronise this data.

This single source can be decentralised, consolidated or any other shape you can imagine as long as the data source and the data relationships are understood, and the outcome results in an ability to see the whole picture about a customer, reseller, product or other important entity.

## MDM Strategy

An MDM strategy sets the tone for the project, outlining why its important and what the expectations are for it.

[McKinsey cites modern data architecture](https://www.mckinsey.com/capabilities/mckinsey-digital/our-insights/how-to-build-a-data-architecture-to-drive-innovation-today-and-tomorrow) as a critical business driver, but it can be one of the most expensive projects a company can take on. A Strategy to adopt the right data capability for the organisation's growth and maturity is essential.

I wrote an example below:

> At Everflow, our mission is to simplify our customer's utility needs. We need to understand their use of utilities and be able to track how we can align their use.
>
> Our MDM strategy reflects our business goals:
>
> * Provide a single view of the customer and their use of our products, so they can quickly see how their usage varies and make educated decisions. Providing this joined-up view allows our 'single quote' and 'single bill' initiatives to succeed and scale
> * To support their brokers and support agents to get the correct information quickly and easily, so we can continue to deliver excellent customer service.
To support and not detract from our main value proposition by offering a lightweight solution which aligns with our values and principles
>
>We will achieve these goals:
>
> * By identifying and managing our Core Master Data, required to create integrated customer experiences
> * Through maintaining authoritative sources, which the broader organisation can easily access
> * Ensuring our data stewardship is fit for purpose as our regulated footprint grows
> * By providing a lightweight service which delivers the necessary functionality in a cost-effective manner
>
>For Everflow, MDM is a critical enabler to our business goals.
>
> * Allows us to create a single view of the customer, their active contracts, and potential upsells
> * Enable us to analyse broker performance and see how different brokers do in other areas
> * Integrate new systems and master customer records, quotes and billing.

This strategy outlines how to achieve this and gain short-term benefits incrementally. The outcomes align with the organisation's goals and explain how MDM is necessary to deliver those goals.

The rest of this article will describe the project necessary to create such a hub and what types of tools will be required.

## Method

An MDM process involves several stages. Not all are essential, but some have to come first.

## 1. Define Business Goals

An important step. Things only happen when there is a tangible goal for the business. MDM drives two main types of value streams:

1. MDM drives a short-term return on its investment by managing inconsistencies, improving analysis and reducing the effort to visualise and analyse data. It boosts responses to customers and partners.
2. A longer-term return is the capability to model and simulate how changes affect business performance. MDM allows business modelling and testing, which can make analytics a strategic investment. It supports acquisition and integration by ensuring new systems adapt to existing data.

It is vital to maintain both the vision (Analytics as a strategic enabler) and the short-term gains (we can show value in the short term by doing -something-) when explaining the importance of MDM and a broader data strategy.

## 2. Identify Master Data

At the start of any project, identify the relevant master data for that project, not all the master data you may ever need, and certainly not all the data you have.

The following characteristics help identify Master Data:

* High Business Value
* Low volatility
* Complex
* Reusable

Master data is only the high-value, complex, reusable entities with low volatility, such as:

* Customers
  * CustomerAccounts
  * CustomerSites
* Brokers
  * BrokerAgents
* Utilities
  * Products
* Contracts
* etc.

Critical data is not necessarily master data. A Brokers training in a utility is vital for compliance, but only in that context. It is not widely reusable, so it wouldn't be considered Master Data.

MDM does not, and should not, include transaction data. That stuff is too fast-moving to manage using this pattern. A data warehouse or an event stream is a better way to manage analytics for transactional data. It could link to the transactional view or the analytical aggregates of the transactions.

From a data warehouse point of view, Master Data fields are critical dimensions which change slowly, but not the facts about those dimensions.

![MDM Entity Analysis](../../media/mdm-field-eval.png)
> Schedlbauer, M. (2019) Master Data Management, shipzero. [Medium](https://medium.com/appanion/10-steps-towards-a-successful-master-data-management-project-1322e20d2241).

 Once we know what they are, we can understand and expose the proper entities and their fields from the right places.

TODO: 'Roll-up' data into entities and resources that can be queried. Then we can work with those bigger objects, confident that we can access the contents if need be.

## 3. Identify & Evaluate Data Sources

Where do we get this data from? Where was it created or first used? How can we trust that it is correct? These are all critical questions to ask on our journey. The next step is to identify where our Master Data comes from and whether that is a system of record.

Identifying the right place to collect different data items is crucial as it lets us integrate or populate data as soon as possible in the lifecycle. Having a clear lineage for each entity increases the ability to diagnose issues with data and ensures data is more accurate and trustworthy.

Following the data lifecycle in an organisation makes the process less invasive or disruptive. Which department/system gets to the entity first? For a new product, it is likely to be Product Management. Sales probably identify a Customer first. Using these 'natural' systems as the system of record and the source of information ensures the organisation captures data soon and remains current.

Evaluate whether these systems have available interfaces to export data, ideally, modern interfaces that drive events.

* Customers comes from SalesForce via a REST API
* Brokers comes from EVIE via a REST API
* Water Data comes from Eclipse via a ...
* Waste Data comes from WASTE via a ...
* Bill information comes from AllOftheAbove via a ...

If possible, having webhooks or an event model means we can quickly raise events when something changes, and each interested system can update its copy of any information.

## 4. Analyse Metadata

Defining and managing metadata for a business would be an entire article or more on its own. Detailed data about your data, who created it, where they created it, when they made it and who last edited it can all add value to a business by increasing understanding of critical entities.

In the context of MDM, metadata requires analysis to check for consistency across systems. Different teams and systems likely use other terms or values for the same things. It's important to align these things to create a shared language for the organisation.

The easiest solution is to add all the different, relevant metadata to the Master Data entity so that other systems can access the metadata. Then train departmental leaders in the correct terms. To allow a colleague to understand who last worked with an entity, what happened to the entity and whether it is live or stale, Metadata should include Comments, Versions, Updates and Editors.

Consider what Master Data Metadata is relevant outside of the source system. Sometimes, there is no actual use outside the source, so leave it there.

## 5. Analyse Data Lifecycles

Who:

* Creates the data
* Updates the data
* Views the data
* Deletes the data

Define these items for each Master Data Entity. These lifecycles define where something is created and edited. At different steps in the lifecycle, other systems are 'the' primary source, and this can vary over time.

A multi-master model is more complex to keep aligned, so avoid it.

### Worked examples

1. Customer is created in [Broker System] when ... [Event] ... By ...
2. Customer is updated in Eclipse when signed up to a Water contract.
3. Customer is viewed in WASTE when ...
4. Customer is viewed in EVIE when ...
5. Customer is deleted in ... when ...

## 6. Appoint Data Stewards

Have two people for each 'entity' who are in the department who creates and uses that entity the most. The two people should be Business, from the department and 'technical' which could be fromt he data team. They should have a working relationship for daily changes/updates and be able to make local decisions if the impact is non-breaking or within budget.

## 7. Choose Architecture and Data Model

* https://www.mckinsey.com/capabilities/mckinsey-digital/our-insights/how-to-build-a-data-architecture-to-drive-innovation-today-and-tomorrow
* https://www.tickingtrend.com/articles/building-a-data-hub#:~:text=Building%20a%20Data%20Hub%201%20Step%201%3A%20Define,Data%20Governance%20...%207%20Step%207%3A%20Data%20Analytics
* https://www.eckerson.com/articles/data-hubs-what-s-next-in-data-architecture

## 8. Choose Infrastructure and Toolset

## 9. Evaluate System Modifications

## 10. Prototyping

## References

1. [Schedlbauer, M. (2019). Master Data Management. Online.](https://medium.com/appanion/10-steps-towards-a-successful-master-data-management-project-1322e20d2241)
