Contrib.Ace
===========

The Ace module for Orchard enables Html, Css and Javascript editing of Body items using the Ace Editor (http://ace.c9.io/).

Features
========
The Css part enables Css snippets for any content. The module automatically attaches Css parts to Pages and Html Widgets.

The Js part enables Javascript snippets for any content. The module automatically attaches Js parts to Pages and Html Widgets.

The Ace module introduces various flavors of Body editing:
- ace: the body editor will switch to Ace editor for advanced HTML editing. Enable this flavor if you prefer editing with pure Html and you don't like TinyMCE's auto formatting.
- tabbedace: the body editor will combine Html, Css and Javascript pars into a Tabbed interface. Editor is Ace for all parts.
- tabbed: the body editor will combine Html, Css and Javascript pars into a Tabbed interface. Editor is TinyMCE for Html and Ace for Css and Javascript.

Quick Setup
===========

Enable the module and change the flavor of any Body Part you like to ace, tabbed and tabbedace instead of html.

The module automatically adds Css and Javacript parts to Pages and Html Widgets.

Dependencies: 
=============
- Orchard.jQuery, 
- Emmet (http://gallery.orchardproject.net/List/Modules/Orchard.Module.js.Emmet/1.7.2.1)
- Underscore (http://gallery.orchardproject.net/List/Modules/Orchard.Module.js.Underscore/1.5.2.1)

