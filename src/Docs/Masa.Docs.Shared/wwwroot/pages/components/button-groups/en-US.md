---
title: Button Groups
desc: "The **MButtonGroup** component is a simple wrapper for **MItemGroup** built specifically to work with **MButton**."
related:
  - /components/buttons
  - /components/icons
  - /components/selection-controls
---

## Usage

Toggle buttons allow you to create a styled group of buttons that can be selected or toggled under `@bind-Value(s)`.

<button-groups-usage></button-groups-usage>

## Examples

### Props

#### Mandatory

A **MButtonGroup** with the `Mandatory` prop will always have a value.

<masa-example file="Examples.components.button_groups.Mandatory"></masa-example>

#### Multiple

A **MButtonGroup** with the `Multiple` prop will allow a user to select multiple return values as an array.

<masa-example file="Examples.components.button_groups.Multiple"></masa-example>

#### Rounded

You can make **MButtonGroup** rounded using the **Rounded** prop.

<masa-example file="Examples.components.button_groups.Rounded"></masa-example>

### Misc

#### Toolbar(TODO:OverflowButton)

Easily integrate customized button solutions with a **MToolbar**.

<masa-example file="Examples.components.button_groups.Toolbar"></masa-example>

#### WYSIWYG

Group similar actions and design your own WYSIWYG component.

<masa-example file="Examples.components.button_groups.WYSIWYG"></masa-example>