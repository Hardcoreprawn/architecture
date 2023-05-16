---
Title: Technical Debt Framework
Lead: Problems with code are like financial debt. It’s OK to borrow against the future, as long as you pay it off before the interest starts to bite.
Description: Help teams manage technical debt by identifying and assessing existing debt across the enterprise and prioritizing items in an orderly fashion.
Tags:
  - Architecture
  - Business
  - Process
  - Solution
Categories:
  - Solution
Draft: true
Published: 01/01/2001
---
## Introduction

We have all been there. There's an urgent business problem. There's a software solution that promises to resolve that issue and make everything great. So we get it. And install it, and then someone doesn't quite finish installing it. And something doesn't work properly. Or someone leaves, and now no one knows how to fix that one thing, and everyone spends time working around it.

This, at its core, is similar to technical debt. It's a shortcut (often documentation), which was made, to speed something up. And in the above case, it's unmanaged and not being repaid, so the business is paying 'interest' on it. And like a lot of credit, the interest can be very destructive.

## Symptoms

* If technology or process decisions require meetings to work around or make decisions, it's a possible sign of technical debt.
* If changes take a long time to make, and as such, decisions to make changes take a long time as well, it could be a sign of technical debt.
If simple changes or expectable business requirements take a long time to be delivered, more than you'd expect, you probably have technical debt.
* If your developers always estimate far too low, then you probably have technical debt.

## The scale of the issue

In a 2020 survey, McKinsey asked a group of CIOs who are part of a panel, what percentage of their budget was being diverted to tech debt, and they responded that 10-20% was typical.

More worrying was the statistic that CIOs felt the value of the technical assets was made up of 20-40% tech debt, before decrepiation.

More recently, a repeat of this study found that 60% of CIOs felt their organisation had perceptibly increased over the past three years.

On a more positive note, the same whitepaper quoted a former CIO at a major cloud provider:

>"By reinventing our debt management, we went from 75 percent of engineer time paying the [tech debt] ‘tax’ to 25 percent. It allowed us to be who we are today."

## Background

As early as 1992, Ward Cunningham used the term Technical debt to explain to management why iterative software development was a better choice:

>Shipping first time code is like going into debt. A little debt speeds development so long as it is paid back promptly with a rewrite… The danger occurs when the debt is not repaid. Every minute spent on not-quite-right code counts as interest on that debt. Entire engineering organizations can be brought to a stand-still under the debt load of an unconsolidated implementation, object-oriented or otherwise. — Ward Cunningham, The WyCash Portfolio Management System, 1992

The analogy keeps going. Not paying technical debt, like credit cards, can swiftly compound the interest. conversely, paying down technical debt early, by refactoring in advance to improve code quality, making it easier to work with, understand and extend, is like saving. That can also compound, improving the agility of your software, and increasing its value and productivity.

> In the book, I make the following definition of “refactoring”
>
> *noun*: a change made to the internal structure of software to make it easier to understand and cheaper to modify without changing its observable behavior
>
> *verb*: to restructure software by applying a series of refactorings without changing its observable behavior. -Martin Fowler, refactoring.com

So, if you develop quickly, and do not give your development teams time to refactor, reassess and improve the software you rely on, it will get more expensive to work on, and gradually become less of an asset and more of a liability.

## Types and causes

None of this is done deliberately. Market conditions, business needs and markets all change. The assumption that machines will survive that change, without proactive maintenance is well disproven. So why do we not treat software machines, or indeed, Value streams with the same attention?

The primary cause is an over-focus on the immediate, without concern for the future. Short-sighted needs, month-end targets, and shareholder dividends, all drive short-term thinking. We'll fix it tomorrow doesn't work if you don't care about tomorrow.

Technical debt can be easily thought of in three types:

* Process debt. The lack of appropriate or correct frameworks to operate modern systems in modern ways.
* People debt. The lack of skills, knowledge and training for people to properly engage in current technologies and processes.
* Technical debt. Unmaintained systems and software, where the cost to maintain or update is increased and keeps increasing.

## Framework for Managing Technical Debt

Technical debt management all boils down to one point really. Pay it back. Don't let it grow. Use the time you have to pay it forward (invest) rather than focus on the next new shiny thing.

> The author would recommend looking at tech debt as part of 'operational change' and 'internal projects', two of the [four types of work](https://uptakedigital.zendesk.com/hc/en-us/articles/115000524374-4-Types-of-Work-in-IT-The-Phoenix-Project-), and giving it up to a 25% share of the work budget. It may be that this is not enough initially. It may be that you can reduce this to 20% overtime, or pay a bit less during a new product launch or so, but overtime, the average should be 20-25% space which can, at the teams discretion, be used for tech savings, or debt payments.

The goal is not to remove tech debt but to keep it at a workable level.

Companies need to identify and track tech debt, to ensure it can be managed to the best advantage.

Tech debt should be dealt with strategically. These principles, based on work from McKinsey, may help:

1. Start with a shared definition of tech debt. Executive and senior management need to have the same understanding of what constitutes tech debt; Process, people and technology which need upgrading to fit the current climate.
2. Treat tech debt as waste in the profit and loss of a value stream of the business. Leaders should acknowledge the capital and opportunity cost of this and have access to information and metrics to track it.
3. Make sure the total cost of the application, its development, cost to serve and debt is tracked. It should cover 100% of the resources necessary. If that changes how you account, then change how you account.
4. Have an agreed process which doesn't penalise teams or people for addressing tech debt. Make sure that incentives encourage the right behaviour and that addressing tech debt is treated as a positive. Don't blame people for it either, someone made that decision with a good intention (we hope).
5. Create items in the product backlog with value, cost, etc. attached. Prioritise a percentage of them in every sprint, to make sure the value is understood and visible.
6. Don't paralyze or immobilise a business to pay tech debt down. It rarely works and isn't sustainable as it encourages people to think someone will just stop everything to fix things. Instead, set down time and resources in daily work to address debt consistently, either proactively or reactively, depending on the team and the workload.
7. When all else fails, if a product or value stream is 'bankrupt' and can't service its debts (i.e. its interest is >50% or so), then explore the option to replace the whole stack. It's drastic, but it may actually be lower risk and ultimately save the product/service.

### Identifying Technical Debt

Sticking to a financial analogy, you can think of tech debt as having two components, just like any other debt:

* The principal. This is the total work required to bring the stack, including processes and people, up to date.
* The interest. is the complexity tax which every single project pays right now. The spike work to understand how to make a change, or use a commodity technology. The debug work to figure out how version x.x varies from x.y. This is the interest and it's paid in productivity.
McKinsey also says that most organisations are paying way more than 10% interest on this debt, as it causes a significant drag on their projects and resources.

![Tech Debt Principle and Interest](https://www.mckinsey.com/~/media/mckinsey/business%20functions/mckinsey%20digital/our%20insights/tech%20debt%20reclaiming%20tech%20equity/svg-tech-debt-exhibit-2.svgz?cq=50&cpy=Center)
>Principal and interest create a strong drag on enterprise value. [Tech debt: Reclaiming tech equity | McKinsey (2020) www.mckinsey.com.](https://www.mckinsey.com/capabilities/mckinsey-digital/our-insights/tech-debt-reclaiming-tech-equity)

### Tracking Technical Debt

Tech debt should be tracked by the team/group head as a key metric. It may be that you have to find a way to expose or count the cost of this debt, which isn't always easy. Some areas you can track:

* Software Development
  * [Complexity](https://linearb.io/blog/what-is-code-complexity/) - These can all be tracked and monitored on each project to understand where the complexity lies and help identify areas which need work.
  * [New Bugs vs Closed Bugs](https://dzone.com/articles/8-top-metrics-for-measuring-your-technical-debt) - Are your bugs growing or falling?
  * [Testing Effort](https://linearb.io/blog/how-to-measure-technical-debt/#:~:text=Measuring%20Technical%20Debt%3A%20Identify%20High-Risk%20Areas%201%20Keep,Risk%20and%20Add%20Importance%20to%20the%20Mix%20) - An easy approximation is to look at test coverage. Test coverage isn't a golden bullet by any means; whilst a low value is a warning, a high volume doesn't mean the tests are good, coverage can show how well-understood a code base is. As such, have a threshold, such as 80% as a target.
* Infrastructure - Track the cost to service and host the application. Compare the current choice with the preferred pattern for hosting the application. Is it worth switching? Will you save time/money?
* Architectural - Does the application follow the organisation's standards and recommendations? Does it follow the vendor's deployment guidance? If it is non-standard, then it will be more expensive/riskier to host and fix. It may cause complexity to host and manage.
* Training - Do you need to hire people for every new technology? Are your team unable to spend time looking at potentially valuable new tools and technologies?

If you mix these with importance and risk, you can approximate the 'value' and start to create a backlog of tech debt.

### Managing Technical Debt

* Have your teams identify tech debt and create features in their existing backlogs for tech debt. Tag them with 'Tech-debt', so they can be reported on and analysed.
  * Do not create a separate backlog. this will slow things down. One team, one backlog.
* Track each feature with risk and importance. This includes tech debt. during sprint planning, pull tech debt items into the backlog to fill up the first 25%. Then maybe lose 1-2 if you have to pull something else forward.
  * Remember, each debt you deal with gives you more bandwidth tomorrow. The compound interest of tech debt payoff can be huge.
* Make sure your product managers understand the value of this work and support it. They need to be able to prioritise tech debt and understand what that budget is doing and where it is going.

## Conclusion


## References

* [Tech debt: Reclaiming tech equity | McKinsey (2020) www.mckinsey.com](https://www.mckinsey.com/capabilities/mckinsey-digital/our-insights/tech-debt-reclaiming-tech-equity).
* [How to Measure Technical Debt Before You Start Tackling It | LinearB (2022) linearb.io](https://linearb.io/blog/how-to-measure-technical-debt/#:~:text=Measuring%20Technical%20Debt%3A%20Identify%20High-Risk%20Areas%201%20Keep) (Accessed: 16 May 2023).

‌
