---
Title: Requirements checklist
Lead: A checklist for checking a requirement is complete and ready to be used.
Draft: false
Tags:
  - Architecture
  - Requirements
Date: 2023-04-24T07:39:05.569Z
Published: 21/04/2023
---

This document should help you write requirements and ensure they are ready for development and implementation. Most organizations have poorly documented guidance about creating requirements and what makes them easy to implement. We all come with assumptions about what requirements are. This document aims to help explain what makes a requirement.

## Defining 'Good Requirement'

A good requirement should be easy to understand for its primary audience. It should help someone who is implementing it to do so with minimal additional research.

The primary audience is the person or group expected to create the feature described in the requirement. It could be an architect, developer, customer, or executive.

It is essential to understand who the requirement is for, so you can include enough context that they don't need to read a load of other stuff to understand it. Just enough context is essential with a distributed, remote or international team, as there is less chance to clarify in person.

A secondary audience is someone interested but won't use it. Again, the important thing is to make sure they can understand it and that you refer to enough context to understand it with some research.

So a reasonable requirement should meet the needs of its audiences, both primary and secondary. This might mean you need two versions or have to include references or links to add additional context for the secondary.

## Understand your audience

It's tough to know if a requirement fits the purpose unless you understand the problem, the context, and the intended user. It is almost impossible to get this right from an ivory tower.

So, when writing requirements, you should understand the problem space, the user space, and the system context. Requirements need to be focussed on how you can meet the needs of a problem in the given context. (i.e., the current system/landscape). This cannot be too blue sky, or it will be unworkable. Imagining that electric vehicles work everywhere for everyone without understanding the logistics of recharging and infrastructure is just wishful thinking.

Make sure your requirements are written for their intended audience

## Enough context

Ensure the requirement is complete and understandable for the primary audience without additional material. (If you cannot do this, there may be some need to educate on the current systems and capabilities.). This should give you something concise, but easy to grasp, without a whole host of specialist knowledge the audience doesn't have.

Different types of requirements have different needs and may create additional requirements. High-level business requirements and low-level technical specifications, considering regulations, can be very other things. Like the first point, ensure they are detailed enough for the audience.

## Clear, simple language

Don't write completely, chaotically complex prose. Could you keep it simple and informative? Not too brief; this is also bad.

The trick is explaining the change/adaption, not the need or complex outcome. Just immediate effects are pleasing. You may have some great ideas about what it might do. Thats fine. It doesn't need to be in the requirement, just enough to ensure someone builds it to a suitable standard.

## Show, don't tell

If you can include an example, a diagram, or a model, do. A lot of people do better with something they can process alongside words. It can add a whole dimension to your text. But it does need to be unambiguous. If your requirement is open to interpretation, the output will also be.

On that note, [here is an example requirement](xref:compatibility)

## Consistent

Reasonable product development requirements are consistent. The development should know how to deal with them, what certain things mean, and how that affects how the software works. Consistency and repetition are helpful in this way. The less someone needs to think about it, the easier and faster it will be to develop.

## Clear accountability

Each requirement has an owner. Each requirement gets implemented by someone. As a Requirement moves from discovery to development, someone must own it to ensure it gets built properly.

## Manage and update the status

Track requirements development. Each requirement adds value to the product. We all want that, so we all are interested in ensuring everyone can find out how it's going. Has it been reviewed? Approved? Implemented? People should be able to find out and see how it's progressing.

## Feedback is key

Understanding that a requirement can morph and change is one of those often overlooked things. It can and should, albeit with the correct approval and review. We all get stuff wrong. Until we have a broad agreement, something will likely need to change, so review early and often and make decisions to keep it moving. If it changes, so be it.

1. Is the requirement complete?
    * Is it a complete sentence?
    * Does the reader/consumer need additional material to understand it?

2. Is the requirement clear?
    * Are there any ambiguous words?
    * Do the relevant stakeholders agree on the meaning of the words?

3. Is the requirement consistent with other conditions?
    * Does this requirement conflict with others?
    * Is the terminology used consistently?

4. Can you test if the output meets the requirement?
    * Are there acceptance criteria?
    * Have you reviewed the requirement with testing or QA?
    * Can you verify through inspection, analysis, or demonstration?

5. Can you trace the requirement and identify it?
    * Does it have a unique ID? Be consistent with this!
    * Do you know where it came from and what outcome it supports?

6. Does the requirement depend on a given design?
    * Does the requirement demand constraints on a design? Are they justified?
    * As written, could you meet the requirement in different ways?

Stay Agile!
