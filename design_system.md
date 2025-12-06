# Design System: Inventory Accounting Application

## 1. PHILOSOPHY
*   **Minimalism**: Clean interfaces with no clutter. Focus on essential elements to reduce cognitive load.
*   **Data-First**: Content is king. Accounting data readability and density are prioritized over decorative elements.
*   **No-BaseForm (Composition)**: We explicitly **REMOVE** "BaseForm" inheritance. The architecture uses a **Composition** pattern. Every form is independent, self-contained, and visually consistent through strict adherence to this style guide.
*   **Professional**: The aesthetic must be trustworthy, precise, and business-focused.

## 2. COLOR PALETTE
### Core Colors
*   **Primary**: `#0F172A` (Dark Blue) - Used for Navigation, Brand elements, Primary Buttons.
*   **Secondary**: `#334155` - Used for Headings, Main Text, Borders.
*   **Accent**: `#3B82F6` (Blue) - Used for Focus states, Active links, Highlights.

### Functional Colors
*   **Success**: `#10B981` (Emerald) - Validations, Success toasts.
*   **Error**: `#EF4444` (Red) - Error messages, Delete actions, Negative balances.
*   **Warning**: `#F59E0B` (Amber) - Alerts, Pending states.

### Backgrounds & Surfaces
*   **App Background**: `#F1F5F9` (Slate 100) - Global page background.
*   **Surface**: `#FFFFFF` (White) - Cards, Modals, Form Containers.

## 3. TYPOGRAPHY
*   **Font Family**: `Inter` or `Roboto`.
*   **Accounting/Numeric Data Rules**:
    *   **Font Style**: MUST use Monospace font (e.g., Roboto Mono) OR standard font with `font-variant-numeric: tabular-nums`.
    *   **Alignment**: MUST be **Text-Align Right** for all monetary and quantitative values.
    *   **Formatting**: Always display consistent decimal places (e.g., 2 for currency).

## 4. FORM & INPUT SPECS
### Container
*   **Style**: White Card (`#FFFFFF`).
*   **Border Radius**: `8px`.
*   **Shadow**: `0 4px 6px -1px rgba(0, 0, 0, 0.1)` (Soft drop shadow).

### Inputs (Text, Number, Date)
*   **Height**: `40px`.
*   **Border**: `#CBD5E1` (1px Solid).
*   **Background**: `#FFFFFF`.
*   **Focus State**: Border Color `#3B82F6`, optional Glow/Ring `#3B82F6`.
*   **Spacing**: Margin bottom 16px between groups.

### Buttons
*   **Primary**:
    *   Background: `#0F172A` (Dark Blue).
    *   Text: White.
*   **Secondary**:
    *   Background: White.
    *   Border: 1px solid `#CBD5E1`.
    *   Text: `#0F172A` or `#334155`.
*   **Danger**:
    *   Background: `#FEE2E2` (Light Red) or `#EF4444` depending on prominence.
    *   Text: `#EF4444` (if light bg) or White (if filled).

## 5. TABLE/GRID SPECS
Used for Lists, Ledgers, and Report Views.

*   **Header**:
    *   Background: `#F8FAFC`.
    *   Text: Semi-bold, `#334155`.
*   **Borders**:
    *   **Horizontal Only**: Use dividers between rows. Avoid vertical borders to reduce noise.
    *   Color: `#E2E8F0`.
*   **Padding**:
    *   `12px` Vertical, `16px` Horizontal.
*   **Row States**:
    *   Hover: slight background darken (`#F1F5F9`).
    *   Selected: Accent color wash (e.g., `#EFF6FF`).

---

## 6. SYSTEM PROMPT FOR AI GENERATION
*Copy and paste the following block when asking an AI to generate new forms or components for this application:*

```text
You are an expert UI Engineer building an Inventory Accounting Application. 
Create a new [Component/Form Name] following these strict Design System rules:

1. ARCHITECTURE:
   - COMPOSITION PATTERN ONLY. Do NOT inherit from any "BaseForm".
   - The form must be a standalone unit.

2. VISUAL STYLING:
   - CONTAINER: White (#FFFFFF) card, 8px Radius, Shadow (0 4px 6px -1px rgba(0,0,0,0.1)).
   - BACKGROUND: Page background is #F1F5F9.
   - INPUTS: Height 40px, Border #CBD5E1. Focus color #3B82F6.
   - BUTTONS: Primary Action = #0F172A (Dark Blue). Cancel/Back = White with #CBD5E1 border.

3. DATA DISPLAY:
   - All accounting numbers (Price, Quantity, Total) must be RIGHT-ALIGNED.
   - Use Monospace font or tabular-nums for figures.
   - Grid/Table Headers: Background #F8FAFC, Horizontal borders only.

Implement the code now ensuring pixel-perfect adherence to these hex codes and specs.
```
