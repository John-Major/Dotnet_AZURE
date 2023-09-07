using Microsoft.AspNetCore.Mvc;

public class CategoryController : Controller {
    private readonly ApplicationDbContext db;
    public CategoryController(ApplicationDbContext db){
        this.db = db;
    }
    public IActionResult Index(){
        IEnumerable<Category> objCategoryList = db.Categories;
        return View(objCategoryList);
    }
}