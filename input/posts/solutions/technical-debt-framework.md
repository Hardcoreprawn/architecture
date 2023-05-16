---
Title: Technical Debt Framework
Slug: technical-debt-framework
Lead: Problems with code are like financial debt. It’s OK to borrow against the future, as long as you pay it off before the interest starts to bite.
Description: Help teams manage technical debt by identifying and assessing existing debt across the enterprise and prioritizing items in an orderly fashion.
Tags:
  - Architecture
  - Business
  - Process
Categories:
  - Process
Draft: true
Published: 01/01/2001
---
## Introduction

We have all been there. There's an urgent business problem. There's a software solution that promises to resolve that issue and make everything great. So we get it. And install it, and then someone doesn't quite finish installing it. And something doesn't work properly. Or someone leaves, and now no one knows how to fix that one thing-, and everyone spends time working around it.

This, at its core, is similar to technical debt. It's a shortcut (often documentation), which was made, to speed something up. And in the above case, it's unmanaged and not being repaid, so the business is paying 'interest' on it. And like a lot of credit, the interest can be very destructive.

## Symptoms

* Meetings.
* Difficulty making changes or decisions
* Long lead times for seemingly simple requests.

## The scale of the issue

## Background

As early as 1992, Ward Cunningham used the term Technical debt to explain to management why itterative software development was a better choice:

>Shipping first time code is like going into debt. A little debt speeds development so long as it is paid back promptly with a rewrite… The danger occurs when the debt is not repaid. Every minute spent on not-quite-right code counts as interest on that debt. Entire engineering organizations can be brought to a stand-still under the debt load of an unconsolidated implementation, object-oriented or otherwise. — Ward Cunningham, The WyCash Portfolio Management System, 1992

The analogy keeps going. Not paying technical debt, like credit cards, can swiftly compound the interest. conversely, paying down technical debt early, by refactoring in advance to improve code quality, making it easier to work with, understand and extend, is like saving. That can also compound, improving the agility of your software, and increasing its value and productivity.

> In the book, I make the following definition of “refactoring”
> *noun*: a change made to the internal structure of software to make it easier to understand and cheaper to modify without changing its observable behavior
> *verb*: to restructure software by applying a series of refactorings without changing its observable behavior.
-Martin Fowler, refactoring.com

So, if you develop quickly, and do not give your development teams time to refactor, reassess and improve the software you rely on, it will get more expensive to work on, and gradually become less of an asset and more of a liability.

## Types and causes

None of this is done deliberately. Market conditions, business needs and markets all change. The assumption that machines will survive that change, without proactive maintenance is well disproven. So why do we not treat software machines, or indeed, Value streams with the same attention?

The primary cause is an over-focus on the immediate, without concern for the future. Short-sighted needs, month-end targets, and shareholder dividends, all drive short-term thinking. We'll fix it tomorrow doesn't work if you don't care about tomorrow.

Technical debt can be easily thought of in three types:

* Process debt. The lack of appropriate or correct frameworks to operate modern systems in modern ways.
* People debt. The lack of skills, knowledge and training for people to properly engage in current technologies and processes.
* Technical debt. Unmaintained systems and software, where the cost to maintain or update is increased and keeps increasing.

## Framework for Managing Technical Debt

### Identifying Technical Debt

### Tracking Technical Debt

### Managing Technical Debt

## Conclusion
