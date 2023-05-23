---
Title: Technical Debt Framework
Lead: Problems with systems are like financial debt. It’s OK to borrow (time) against the future, as long as you pay it off before the 'interest' starts to bite...
Description: Help teams manage technical debt by identifying and assessing existing debt across the enterprise and prioritizing items in an orderly fashion.
Tags:
  - Architecture
  - Business
  - Process
  - Solution
Categories:
  - Solution
Draft: False
Published: 23/05/2023 
---
> ## TL;DR
>
> Technical debt is a hidden bleed on cost, productivity and morale. You can address it by accepting it exists, socialising the subject and putting in place ways to address it without blame.
>
> There are three main forms, process, people or technology. These relate to what you have neglected to maintain. They are best addressed as an accepted part of life, rather than with any major effort.
>
> Leave space in your team's workflow to accommodate and address these issues and rather than being a debt which is compounding liability against your business, it will become a compounding investment, which pays for itself over time.

## Introduction

We have all been there. There's an urgent problem. There's software that should resolve it and make everything great.

So we get it. And install it, and then someone doesn't quite finish installing it. And something doesn't work properly. Or someone leaves, and now no one knows how to fix that one thing, and everyone spends time working around it.

And we have to upgrade it every few months in some complicated ritual. And the renewals just seem to get more expensive and complicated every year...

This is technical debt. It's the well-meant shortcut we took to speed something up. And now, it's unmanaged and not being repaid. The business is paying 'interest' on it. And like a lot of credit, the interest can be destructive.

## Symptoms

* If technology or process decisions require meetings to work around or make decisions, you probably have technical debt.
* If changes take a long time to make, and as such, decisions to make changes take a long time as well, you probably have technical debt.
* If simple changes or expectable business requirements take a long time to be delivered, you probably have technical debt.
* If your developers always estimate far too low and deliver way later, then you probably have technical debt.
* If you use technology in your business, you probably have technical debt.

## The scale of the issue

In a 2020 survey, McKinsey asked a group of CIOs who are part of a panel, what percentage of their budget was being diverted to managing tech debt, and they responded that 10-20% was typical.

More worrying was the statistic that CIOs felt the value of the technical assets was made up of 20-40% tech debt, before depreciation.

More recently, a repeat of this study found that 60% of CIOs felt their organisation's tech debt had perceptibly increased over the past three years.

On a more positive note, the same whitepaper quoted a former CIO at a major cloud provider:

>"By reinventing our debt management, we went from 75 percent of engineer time paying the [tech debt] ‘tax’ to 25 percent. It allowed us to be who we are today."

## Background

At WyCash in 1992, Ward Cunningham used the term Technical debt to explain to management why iterative software development was a better choice:

>Shipping first time code is like going into debt. A little debt speeds development so long as it is paid back promptly with a rewrite… The danger occurs when the debt is not repaid. Every minute spent on not-quite-right code counts as interest on that debt. Entire engineering organizations can be brought to a stand-still under the debt load of an unconsolidated implementation, object-oriented or otherwise. — Ward Cunningham, The WyCash Portfolio Management System, 1992

Ward Cunningham was also one of the authors of the Agile Manifesto in 2008.

The analogy keeps going. Not paying technical debt, like credit cards, can swiftly compound the interest. Conversely, paying down technical debt early, by refactoring in advance to improve quality is like saving. That can also compound, improving the agility of your software, and increasing its value and productivity over time, quite drastically.

Martin Fowler, noted author and software architect, had this to say:

> In the book, I make the following definition of “refactoring”
>
> *noun*: a change made to the internal structure of software to make it easier to understand and cheaper to modify without changing its observable behavior
>
> *verb*: to restructure software by applying a series of refactorings without changing its observable behavior. -Martin Fowler, refactoring.com

So, if you push features too quickly, and do not give your development teams time to refactor, reassess and improve the systems you rely on, it will get more expensive to work on. Over time, these systems become less of an asset and more of a liability.

## Types and causes

None of this is done deliberately. Market conditions, business needs and markets all change. The assumption that machines will survive that change, without proactive maintenance is disproven. So why do we not treat "software machines" or the business systems that use them, with the same care?

The primary cause is an over-focus on the immediate, without concern for the future. Short-sighted needs, month-end targets, and shareholder dividends, all drive short-term thinking. "We'll fix it tomorrow" doesn't work if you don't care about tomorrow.

Technical debt can be easily thought of in three types:

* Process debt. The lack of appropriate or correct frameworks to operate modern systems in modern ways.
* People debt. The lack of skills, knowledge and training for people to properly engage in current technologies and processes.
* Technical debt. Unmaintained systems and software, where the cost to maintain or update is increased and keeps increasing.

Whilst most people will recognise the third, I suspect a lot ignore or don't consider the first two. I would argue the first is the most worry-some. Process debt leads shows up in phrases like 'That's not how we do that' and frustrations with 'the way things are'. It makes people feel disempowered. Being unable to make things better makes people feel helpless.

Everyone acknowledges that education is good, but employees want to feel cared about and invested in. Ensuring that training happens is important for employee engagement, as well as productivity. It means they know how to use the systems the business invests in, as well as care about the way the business works.

## Framework for Managing Technical Debt

Technical debt management boils down to one point. You have to pay it back. It will not go away. Factor it into daily work. If it's low, use the time to pay it forward (invest) rather than focus on the next new shiny thing.

> The author would recommend giving it up to a 25% share of the work budget to team led 'improvement', which includes tech debt. It may be that this flexes up and down a bit, but 20-25% in the long term will keep your software improving.

The goal is not to remove tech debt entirely but to keep it at a workable level.

Companies need to identify and track tech debt, to ensure it can be managed to the best advantage.

Tech debt should be dealt with strategically. These principles, based on work from McKinsey, may help:

1. Start with a shared definition of tech debt. Executive and senior management need to have the same understanding of what constitutes tech debt; Process, people and technology, which need upgrading.
2. Treat tech debt as 'waste in the P&L' of the business. Leaders should acknowledge the capital and opportunity cost of this and have access to information and metrics to track it.
3. Make sure the total cost of the application, its development, cost to serve and debt is tracked. It should cover 100% of the resources necessary. If that changes how you account, then change how you account. (See 'process debt' above)
4. Have an agreed process, which *doesn't penalise* teams or people for addressing tech debt. Make sure that incentives encourage the right behaviour and that addressing tech debt is treated as a positive. Don't blame people for it either, someone made that decision with a good intention.
5. Have teams Create items in the product backlog with value, cost, etc. attached. Prioritise a percentage of them in every sprint, to make sure the value is understood and visible. Treat them as features, just like others and value them. They weren't written up for the fun of it...
6. Don't paralyze or immobilise a business to pay tech debt. It rarely works and isn't sustainable. It encourages people to think someone will just stop everything to fix things. Instead, set down time and resources in daily work to address debt consistently, either proactively or reactively, depending on the team and the workload.
7. When all else fails, if a product or value stream is 'bankrupt' and can't service its debts (i.e. its 'interest' is >50% or so), then explore the option to replace the whole stack. It's drastic, but it may be a lower-risk option and save the product/service.

### Identifying Technical Debt

Sticking to a financial analogy, you can think of tech debt as having two components, just like any other debt:

* The principal. This is the total work required to bring the stack, including processes and people, up to date.
* The interest. is the complexity tax which every single project pays right now. The spike work to understand how to make a change, or use a commodity technology. The debug work to figure out how version x.x varies from x.y. This is the interest and it's paid in productivity.
McKinsey also says that most organisations are paying way more than 10% interest on this debt, as it causes a significant drag on their projects and resources.

![Tech Debt Principle and Interest](https://www.mckinsey.com/~/media/mckinsey/business%20functions/mckinsey%20digital/our%20insights/tech%20debt%20reclaiming%20tech%20equity/svg-tech-debt-exhibit-2.svgz?cq=50&cpy=Center)
>Principal and interest create a strong drag on enterprise value. [Tech debt: Reclaiming tech equity | McKinsey (2020) www.mckinsey.com.](https://www.mckinsey.com/capabilities/mckinsey-digital/our-insights/tech-debt-reclaiming-tech-equity)

### Tracking Technical Debt

Tech debt should be tracked by the team/group as a key metric. It may be that you have to find a way to expose or count the cost of this debt, which isn't always easy. Some areas you can track:

* Software Development
  * [Complexity](https://linearb.io/blog/what-is-code-complexity/) - Various code complexity metrics can be tracked and monitored on each project to understand where the complexity lies and help identify areas which need work.
  * [New Bugs vs Closed Bugs](https://dzone.com/articles/8-top-metrics-for-measuring-your-technical-debt) - Are your bugs growing or falling?
  * [Testing Effort](https://linearb.io/blog/how-to-measure-technical-debt/#:~:text=Measuring%20Technical%20Debt%3A%20Identify%20High-Risk%20Areas%201%20Keep,Risk%20and%20Add%20Importance%20to%20the%20Mix%20) - An easy approximation is to look at test coverage. Test coverage isn't a golden bullet by any means; whilst a low value is a warning, a high volume doesn't mean the tests are good, coverage can show how well-understood a code base is. As such, have a threshold, such as 80% as a target.
* Infrastructure - Track the cost to service and host the application. Compare the current choice with the preferred pattern for hosting the application.
* Architectural - Does the application follow the organisation's standards and recommendations? Does it follow the vendor's deployment guidance? If it is non-standard, then it will be more expensive/riskier to host and fix. It may cause complexity to host and manage.
* Training - Do you need to hire people for every new technology? Are your team unable to spend time looking at potentially valuable new tools and technologies?

If you mix these with importance and risk, you can approximate the 'value' and start to create a backlog of tech debt.

### Managing Technical Debt

* Have your teams identify tech debt and create features in their existing backlogs for tech debt. Tag them with 'Tech-debt', so they can be reported on and analysed.
  * Do not create a separate backlog. this will slow things down. One team, one backlog.
* Track each feature with risk and importance. This includes tech debt. During sprint planning, pull tech debt items into the backlog to fill up the first 25%. Feel free to move some out to make way for important features, but prioritise debt over 'Should' or 'Could' features.
  * Remember, each debt you deal with gives you more bandwidth tomorrow. The compound interest of tech debt payoff can be huge.
* Make sure your product managers understand the value of this work and support it. They need to be able to prioritise tech debt and understand what that budget is doing and where it is going.

## Conclusion

Technical debt is a shortcut that was made to speed something up. It’s a lack of appropriate or correct frameworks to operate modern systems in modern ways. It’s the lack of skills, knowledge and training for people to properly engage in current technologies and processes. It’s unmaintained systems and software, where the cost to maintain or update is increased and keeps increasing.

Every business has these.

Technical debt management boils down to one point. Pay it back. The goal is not to remove tech debt but to keep it at a workable level. Companies need to identify and track tech debt, to ensure it can be managed to the best advantage.

## References

* [Tech debt: Reclaiming tech equity | McKinsey (2020) www.mckinsey.com](https://www.mckinsey.com/capabilities/mckinsey-digital/our-insights/tech-debt-reclaiming-tech-equity).
* [How to Measure Technical Debt Before You Start Tackling It | LinearB (2022) linearb.io](https://linearb.io/blog/how-to-measure-technical-debt/#:~:text=Measuring%20Technical%20Debt%3A%20Identify%20High-Risk%20Areas%201%20Keep) (Accessed: 16 May 2023).
* [My 20-year career is technical debt](https://blog.visionarycto.com/p/my-20-year-career-is-technical-debt)
