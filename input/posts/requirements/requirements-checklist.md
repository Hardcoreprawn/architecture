---
Title: Requirements checklist
Description: A checklist for checking a requirement is complete and ready to be used.
Draft: false
Tags:
  - Architecture
  - Requirements
Date: 2023-04-24T07:39:05.569Z
Published: 21/04/2023
Type: default
---

This document should help you write good requirements and make sure they are ready for development and implementation. Most organizations have poorly documented guidance about creating requirements and what makes them easy to implement. It is also hard to know what everyone's assumptions of a good requirement are. This document aims to help explain what makes a good requirement.

## Defining 'Good Requirement'

A good requirement should be easy to understand for its primary audience. It should help someone who is implementing it to do so, with minimal additional research.

A primary audience is a person or group who is expected to be the direct consumer. It could be an architect or a developer, a customer or an executive. It is just important to understand who the requirement is for, so you can include enough context that they don't need to read a load of other stuff to understand it. This is doubly important with a distributed, remote or international team, as there is less chance to clarify in person.

A secondary audience is someone interested, but won't use it. This could be a customer, a developer, or an executive. Again, the important thing is to make sure they can understand it, and you refer to enough context that they can understand it, with a little research if they're not as competent in this field.

So a good requirement should meet the needs of its audiences, both primary and secondary. This might mean you need two versions, or that you have to include references or links to add additional context for the secondary.

## Understand your audience

It's very hard to know if a requirement is fit for purpose unless you understand the problem, the context and the intended user. It is almost impossible to get this right from an ivory tower.

So, when writing requirements, you should understand the problem space, the user space and the system context. Requirements need to be focussed on how you can meet the needs of a problem, in the given context. (i.e. the current system/landscape). This cannot be too blue sky, or it will be unworkable. Imagining that electric vehicles work everywhere for everyone, without understanding the logistics of recharging, and infrastructure is just wishful thinking.

Make sure your requirements are written for their intended audience

## Enough context

Make sure that the requirement is complete, and understandable, without any additional material, for the primary audience. (If you cannot do this, then maybe there is some need to educate on the current systems and capabilities...). This should give you something succinct, but easy to grasp, without a whole host of specialist knowledge the audience doesn't have.

Different types of requirements have different needs and may create additional requirements. High-level business requirements and low-level technical specifications, taking into account regulations, can be very different things. Similar to the first point, make sure they are detailed enough for the audience in question.

## Clear, simple language

Don't write completely, chaotically complex prose. Keep it simple and informative. Not too brief, this is also bad.

The trick is to explain the change/adaption, but not the need or any complex outcome. Just immediate outcomes are fine. You may have some great ideas about what it might do. Thats fine. It doesn't need to be in the requirement, just enough to make sure someone builds it to the right standard.

## Show, don't tell

If you can include an example, a diagram or a model, do. A lot of people do better with something they can process alongside words. It can add a whole dimension to your text. But it does need to be unambiguous. If your requirement is open to interpretation, the output will be as well.

On that note, [here is an example requirement](xref:compatibility)

## Consistent

Good product development requirements are consistent. The development should know how to deal with them, what certain things mean and how that affects the way the software works. Consistency and repetition are helpful in this way. The less someone needs to think about it, the easier and faster it will be to develop.

## Clear accountability

Each requirement has an owner. Each requirement gets implemented by someone. The process of managing this needs to ensure ownership is clear during the process of development and that the implementer can talk to the designer or owner as necessary, to get clarity and understand what was meant.

## Manage and update the status

Track requirements development. Each requirement adds value to the product. We all want that, so we all have an interest in making sure everyone can find out how it's going. Has it been reviewed? Approved? Implemented? People should be able to find out and see how it's progressing.

## Feedback is key

Understanding that a requirement can morph and change is one of those often overlooked things. It can and should, albeit with the right degree of approval and review. We all get stuff wrong. Until we have a broad agreement, something is likely to need to change, so review early, and often and make decisions to keep it moving. If it changes, so be it.

1. Is the requirement complete?
    * Is it a complete sentence?
    * Does the reader/consumer need additional material to understand it?

2. Is the requirement clear?
    * Are there any ambiguous words?
    * Do the relevant stakeholders agree on the meaning of the words?

3. Is the requirement consistent with other requirements?
    * Does this requirement conflict with others?
    * Is the terminology used consistently?

4. Can you test if the requirement has been met?
    * Are there acceptance criteria?
    * Have you reviewed the requirement with testing or QA?
    * Can you verify the requirement through inspection/analysis/demonstration?

5. Can you trace the requirement and identify it?
    * does it have a unique ID? Be consistent with this!
    * Do you know where it came from, and what outcome it supports?

6. Does the requirement depend on a given design?
    * Does the requirement demand constraints on a design? Are they justified?
    * As written, could you meet the requirement in different ways?

Stay Agile!
