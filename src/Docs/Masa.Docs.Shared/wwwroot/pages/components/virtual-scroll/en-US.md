---
title: Virtual scroller
desc: "The MVirtualScroll component displays a virtual, infinite list. It supports dynamic height and scrolling vertically."
related:
  - /components/lists
  - /components/data-tables
  - /components/data-iterators
--- 

## Usage


## Anatomy

## Examples

### Props

#### Bench

By default **MvirtualScroll** will not prerender other items that appear outside the viewable range。 Using the **OverscanCount** property will cause the scrollbar to render additional items as substitute。rehydrating it with new data.

<masa-example file="Examples.components.virtual_scroll.Bench"></masa-example>

#### UserDirectory

**MvirtualScroll** component can render an unlimited amount of items by rendering only what it needs to fill the scroller’s viewport，**ItemSize** property to set the pixel height of each item.

<masa-example file="Examples.components.virtual_scroll.UserDirectory"></masa-example>