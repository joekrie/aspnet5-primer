class: center, middle

# ASP.NET 5
## New features, gotchas, &amp; more
---

## Agenda

1. Introduction
2. Deep-dive
3. ...

---

## C&#35;

```cs 
public class Startup
{
    public void Configuration(IAppBuilder app)
    {
    }
}
```

---

## Razor

```none
<div class="navbar-header">
    <a href="#" class="navbar-toggle collapsed" type="button" data-toggle="collapse" data-target=".navbar-collapse" aria-controls="navbar">
        <span class="sr-only">Toggle navigation</span>
        <img class="collapsed" src="~/Static/Images/menu-burger.png"/>
*       <img class="expanded" src="~/Static/Images/menu-x.png"/>
    </a>
    <a class="ilm-navbar-brand" href="@Url.Action("Index", "Home")">
        <img alt="ILM - Knowledge Meets Passion" src="~/Static/Images/ilm-white.png" />
    </a>
</div>
```

---

## Acknowledgements
* remark.js: slideshow framework
* Roboto &amp; Roboto Slab: fonts
* Inconsolata: source code font