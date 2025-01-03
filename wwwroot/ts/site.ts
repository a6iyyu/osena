document.addEventListener("DOMContentLoaded", () => {
  // Hamburger Menu
  const HamburgerMenu = document.getElementById("hamburger-menu") as HTMLElement;
  const Sidebar = document.getElementById("sidebar") as HTMLElement;
  const Close = document.getElementById("close") as HTMLElement;

  HamburgerMenu.addEventListener("click", () => {
    Sidebar.classList.add("translate-x-0");
    document.body.style.overflow = "hidden";
  });

  Close.addEventListener("click", () => {
    Sidebar.classList.remove("translate-x-0");
    document.body.style.overflow = "auto";
  });

  // Keuntungan Modal Effect On Click
  const KeuntunganModal = document.querySelectorAll("#keuntungan-card") as NodeListOf<HTMLElement>;

  KeuntunganModal.forEach((modal, index) => {
    modal.addEventListener("click", () => {
      let elements = [];
      index % 2 === 0 ? elements = [0, 2] : elements = [1, 3];

      elements.forEach((i) => {
        const targetModal = KeuntunganModal[i];
        targetModal.classList.contains("lg:-translate-y-6") ? targetModal.classList.remove("lg:-translate-y-6") : targetModal.classList.add("lg:-translate-y-6");
      });
    });
  });

  // Bagaimana Kami Bekerja Modal Effect On Click
  const BagaimanaKamiModal = document.querySelectorAll("#bagaimana-kami-bekerja-card") as NodeListOf<HTMLElement>;

  BagaimanaKamiModal.forEach((modal) => {
    modal.addEventListener("click", () => {
      BagaimanaKamiModal.forEach((active) => {
        active.classList.add("border-dashed");
        active.classList.remove("border-solid", "bg-green-50");
        active.querySelector("span")?.classList.add("hidden");
      });
  
      if (modal.classList.contains("border-dashed")) {
        modal.classList.remove("border-dashed");
        modal.classList.add("border-solid", "bg-green-50");
        modal.querySelector("span")?.classList.remove("hidden");
      } else {
        modal.classList.remove("border-solid", "bg-green-50");
        modal.classList.add("border-dashed");
        modal.querySelector("span")?.classList.add("hidden");
      }
    });
  });
});