---
Title: Master Data and How to Manage it
Lead: Master Data defines how an organisation interacts with their customers and should be defined and managed.
Description: ""
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

Master data management (MDM) is the organisation of people, processes and technologies to create and maintain an authoritative, reliable, sustainable, accurate, and secure data environment representing a “single version of the truth” for master data and its relationships across the enterprise. MDM involves creating a single master record for each person, place, or thing in a business across internal and external data sources and applications. This information has been de-duplicated, reconciled and enriched, becoming a consistent, reliable source. Through MDM, an organisation can disseminate consistent and accurate master data across its entire enterprise.

Master data management (MDM) has several benefits. It helps businesses drive efficiencies, improve data quality, revenue growth, and customer experience. MDM also ensures data consistency and accuracy and avoids fluctuations in how closely data flow tracks the underlying patterns. With MDM capabilities, organisations can improve their master data quality, resulting in fewer errors and less redundancy. Some benefits of establishing master data management include improving efficiencies and having all your organisation’s most critical data up to date in one shared location.

## MDM Strategy

At Everflow, our mission is to simplify our customer's utility needs. We need to understand their use of utilities and be able to track how we can align their use.

Our MDM strategy reflects this. Its goals are to:

* Provide a single view of the customer and their use of our products, so they can quickly see how their usage varies and make educated decisions. Providing this joined-up view allows our 'single quote' and 'single bill' initiatives to succeed and scale.
* To support their brokers and support agents to get the correct information quickly and easily, so we can continue to deliver excellent customer service.
To support and not detract from our main value proposition by offering a lightweight solution which aligns with our values and principles.

We will achieve these goals:

* By identifying and managing our Core Master Data, required to create integrated customer experiences
* Through maintaining authoritative sources, which the broader organisation can easily access
* Ensuring our data stewardship is fit for purpose as our regulated footprint grows
* By providing a lightweight service which delivers the necessary functionality in a cost-effective manner

For Everflow, MDM is a critical enabler to our business goals.

* Allows us to create a single view of the customer, their active contracts, and potential upsells
* Enable us to analyse broker performance and see how different brokers do in other areas
* Integrate new systems and master customer records, quotes and billing.

## Process

An MDM process involves several stages. Not all are essential, but some have to come first.

### 1. Define Business Goals

An important step. Things only happen when there is a tangible goal for the business. MDM drives two main types of value streams:

1. MDM drives a short-term return on its investment by managing inconsistencies, improving analysis and reducing the effort to visualise and analyse data.
2. A longer-term return is the capability to model and simulate how changes affect business performance. MDM allows business modelling and testing, which can make analytics a strategic investment.

It is vital to maintain both the vision (Analytics as a strategic enabler) and the short-term gains (we can show value in the short term by...) when explaining the importance of MDM and a broader data strategy.

### 2. Identify Master Data

At the start of any MDM project, identify the relevant Master Data. Not all the Master Data you may ever need, and not all the data is Master Data.

The following characteristics help identify Master Data:

* High Business Value
* Low volatility
* Complex
* Reusable

MDM does not, and should not, include transaction data. That stuff is too fast-moving to manage using this pattern. A data warehouse or an event stream is a better way to manage analytics for transactional data.

From a data warehouse point of view, Master Data fields are critical dimensions which change slowly, but not the facts about those dimensions.

A Matrix or Dictionary can help identify Master Data by categorising data entities against key headers:

* Business Value
* Volatility
* Re-usability
* Complexity

![Entity graded for MDM]‌(../../media/mdm-field-eval.png "A table of fields, scored by MDM indicators")

> Schedlbauer, M. (2019) Master Data Management, shipzero. [Medium](https://medium.com/appanion/10-steps-towards-a-successful-master-data-management-project-1322e20d2241)

### 3. Identify & Evaluate Data Sources

### 4. Analyse Metadata

### 5. Analyse Data Lifecycles

### 6. Appoint Data Stewards

### 7. Choose Architecture and Data Model

### 8. Choose Infrastructure and Toolset

### 9. Evaluate System Modifications

### 10. Prototyping

## References

1. https://medium.com/appanion/10-steps-towards-a-successful-master-data-management-project-1322e20d2241